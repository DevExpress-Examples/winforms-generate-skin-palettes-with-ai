using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.AI.WinForms.AIGeneratePalette.Helpers;
using DevExpress.AIIntegration.Extensions;
using DevExpress.AIIntegration.Services.Chat;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Svg;
using DevExpress.Utils.Svg.Extensions;
using Microsoft.Extensions.AI;

namespace DevExpress.AI.WinForms.AIGeneratePalette {
    /// <summary>
    /// Immutable request object for palette generation. It stores the reference SVG palette and the user prompt.
    /// The request remains lightweight and avoids heavy operations.
    /// </summary>
    public sealed class GeneratePaletteRequest : BaseRequest {
        /// <summary>
        /// Raw natural language instruction entered by the end user. Trimmed and never null or empty after construction.
        /// </summary>
        public string UserPrompt { get; private set; }

        /// <summary>
        /// Skin provider (LookAndFeel) that retrieves the active DevExpress skin and palette context. Requires SVG skin support.
        /// </summary>
        public ISkinProvider LookAndFeelProvider { get; private set; }

        /// <summary>
        /// Conversation messages preceding the current user request, injected in order before the final message.
        /// </summary>
        public IList<AIConversationMessage> ConversationMessages { get; } = new List<AIConversationMessage>();

        /// <summary>
        /// Reference palette captured at construction. Serves as the basis for AI modifications.
        /// </summary>
        internal SvgPalette CurrentPalette { get; private set; }

        /// <summary>
        /// Creates a new request.
        /// </summary>
        /// <param name="userPrompt">Natural language description of desired palette changes.</param>
        /// <param name="lookAndFeelProvider">Skin provider that supplies the current DevExpress skin context.</param>
        /// <exception cref="ArgumentException">If userPrompt is null or empty, or if the skin provider does not support SVG.</exception>
        /// <exception cref="ArgumentNullException">Throw if lookAndFeelProvider is null.</exception>
        public GeneratePaletteRequest(string userPrompt, ISkinProvider lookAndFeelProvider) {
            if(string.IsNullOrWhiteSpace(userPrompt))
                throw new ArgumentException("User prompt cannot be empty", nameof(userPrompt));
            if(lookAndFeelProvider == null)
                throw new ArgumentNullException(nameof(lookAndFeelProvider));
            if(!lookAndFeelProvider.IsSvgSkin())
                throw new ArgumentException("The provided skin provider does not support SVG skins.", nameof(lookAndFeelProvider));

            UserPrompt = userPrompt.Trim();
            LookAndFeelProvider = lookAndFeelProvider;
            // Capture a snapshot of the current palette. The skin's default palette serves as the reference input for the AI system prompt.
            CurrentPalette = CommonSkins.GetSkin(lookAndFeelProvider).SvgPalettes[Skin.DefaultSkinPaletteName];
        }
    }

    /// <summary>
    /// Chat message that maintains conversational history during interaction with the AI model.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class AIConversationMessage {
        /// <summary>
        /// Sender role (User, Assistant, or System) as recognized by the LLM.
        /// </summary>
        public ChatRole Role { get; }
        /// <summary>
        /// Text content of the message. Never null. May be empty.
        /// </summary>
        public string Content { get; }

        public AIConversationMessage(ChatRole role, string content) {
            Role = role;
            Content = content ?? string.Empty;
        }
    }

    /// <summary>
    /// Response object produced by the AI extension.
    /// It wraps the raw model output and provides parsing logic to convert the text into a strongly typed SvgPalette.
    /// </summary>
    public sealed record class GeneratePaletteResponse : BaseResponse {
        /// <summary>
        /// Construct a response from the raw chat data returned by the AI client.
        /// </summary>
        /// <param name="chatResponse">Underlying service response.</param>
        public GeneratePaletteResponse(ChatResponse chatResponse)
            : base(chatResponse.Text, chatResponse.FinishReason is null ? ResponseStatus.Completed : ResponseStatus.Error) {
        }

        /// <summary>
        /// Indicate whether a valid palette was parsed from the AI response text.
        /// </summary>
        public bool IsValid => Result != null;

        /// <summary>
        /// Parsed resulting palette (null if parsing failed).
        /// </summary>
        public SvgPalette Result { get; private set; }

        /// <summary>
        /// Optional human-readable explanation extracted from lines that are not key:value pairs.
        /// </summary>
        public string Explanation { get; private set; } = string.Empty;

        /// <summary>
        /// Parse the textual response and create a new SVG palette instance.
        /// </summary>
        /// <param name="request">Original request that supplies the reference palette for context.</param>
        /// <returns>True if parsing produces a valid palette with at least one modification.</returns>
        internal bool ParseToPalette(GeneratePaletteRequest request) {
            if(string.IsNullOrWhiteSpace(Response))
                return false;
            SvgPalette parsed;
            string explanation = string.Empty;
            if(GeneratePaletteResponseHelpers.TryCreatePaletteFromResponse(Response, request.CurrentPalette, out parsed, out explanation)) {
                Result = parsed;
                Explanation = explanation;
                return true;
            }
            return false;
        }
    }

    /// <summary>
    /// AI extension that handles palette generation, prompt crafting, and conversation replay.
    /// Inherits from ChatAIExtensionBase to leverage DevExpress AI integration infrastructure.
    /// </summary>
    public sealed class GeneratePaletteExtension : ChatAIExtensionBase<GeneratePaletteRequest, GeneratePaletteResponse> {
        /// <inheritdoc />
        public GeneratePaletteExtension(IServiceProvider serviceProvider) : base(serviceProvider) { }

        /// <summary>
        /// Wrap the low-level chat response in a strongly typed domain response.
        /// </summary>
        protected override GeneratePaletteResponse GetResponse(ChatResponse chatResponse) => new GeneratePaletteResponse(chatResponse);

        /// <summary>
        /// Supply the system prompt, including usage instructions and a detailed description of the current palette.
        /// </summary>
        protected override string GetSystemPrompt(GeneratePaletteRequest request) {
            // Template stored as an embedded markdown resource for easy modification without code changes.
            string result = GeneratePaletteResponseHelpers.GeneratePaletteSystemPrompt;
            string paletteDescription =  GeneratePaletteResponseHelpers.GetPaletteDescription(request.CurrentPalette, request.LookAndFeelProvider);
            return result + Environment.NewLine + paletteDescription;
        }

        /// <summary>
        /// Inject historical messages before the final user prompt to enable iterative refinement.
        /// </summary>
        protected override void BuildRequestMessages(ChatMessageRequest chatRequest, GeneratePaletteRequest request, RequestContext context) {
            base.BuildRequestMessages(chatRequest, request, context);
            foreach(var msg in request.ConversationMessages) {
                // The last message is the user request added by the base implementation. Insert history immediately before it.
                chatRequest.Messages.Insert(chatRequest.Messages.Count - 1, new ChatMessage(msg.Role, msg.Content));
            }
        }

        /// <summary>
        /// Execute the AI call and parse the palette. Return a fallback error response if parsing fails.
        /// </summary>
        public override async Task<GeneratePaletteResponse> ExecuteAsync(GeneratePaletteRequest request, CancellationToken cancellationToken) {
            var result = await base.ExecuteAsync(request, cancellationToken).ConfigureAwait(false);
            if(result.ParseToPalette(request))
                return result; // success
            // Fallback standardised error response (keeps UX consistent)
            return new GeneratePaletteResponse(new ChatResponse(new ChatMessage(ChatRole.Assistant, "Failed to generate a valid palette.")) { FinishReason = ChatFinishReason.Stop });
        }

        /// <summary>
        /// Return the user prompt. It is already validated and trimmed in the request constructor.
        /// </summary>
        protected override string GetUserPrompt(GeneratePaletteRequest request, RequestContext context) => request.UserPrompt;
    }
}
