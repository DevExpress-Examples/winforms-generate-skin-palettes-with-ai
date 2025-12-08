using System;
using Azure.AI.OpenAI;
using DevExpress.Data.Utils;
using DevExpress.AI.WinForms.AIGeneratePalette.Demo.Logging;
using DevExpress.XtraEditors;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.Logging;
using OpenAI.Chat;
using System.ClientModel.Primitives;
using System.Net.Http;

namespace DevExpress.AI.WinForms.AIGeneratePalette.Demo.AI {
    /// <summary>
    /// Factory that creates configured IChatClient instances.
    /// It encapsulates Azure OpenAI client setup, resolves environment variables, and supports optional logging.
    /// </summary>
    internal static class ChatClientFactory {
        static AzureOpenAIClient azureOpenAIClient; // cached

        /// <summary>
        /// Creates an AI chat client for the specified model name.
        /// </summary>
        public static IChatClient Create(string modelName) {
            EnsureClient();
            IChatClient chatClient = azureOpenAIClient.GetChatClient(modelName.Trim()).AsIChatClient();
            if(modelName == "gpt-5-mini") {
                // GPT-5 requires that you set the reasoning effort level explicitly.
                chatClient = chatClient.AsBuilder().ConfigureOptions(x => {
#pragma warning disable OPENAI001
                    x.RawRepresentationFactory = _ => new ChatCompletionOptions() {
                        ReasoningEffortLevel = ChatReasoningEffortLevel.Low
                    };
#pragma warning restore OPENAI001
                }).Build();
            }

            if(SimpleFileLogger.EnableLogging) {
                var loggerFactory = LoggerFactory.Create(builder => builder
                    .AddProvider(SimpleFileLoggerProvider.Instance)
                    .SetMinimumLevel(LogLevel.Trace));
                chatClient = chatClient.AsBuilder().UseLogging(loggerFactory).Build();
            }
            return chatClient;
        }

        static void EnsureClient() {
            if(azureOpenAIClient != null) return;
            azureOpenAIClient = new AzureOpenAIClient(AzureOpenAIEndpoint, AzureOpenAIKey, new AzureOpenAIClientOptions() {
                Transport = new PromoteHttpStatusErrorsPipelineTransport()
            });
        }

        // ---- Environment helpers (moved from Program.cs) ----
        static Uri AzureOpenAIEndpoint {
            get {
                string azureOpenAIEndpoint = GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT", IsDeveloperMode);
                if(string.IsNullOrEmpty(azureOpenAIEndpoint))
                    azureOpenAIEndpoint = "https://public-api.devexpress.com/demo-openai"; // DevExpress proxy-server
                return new Uri(azureOpenAIEndpoint);
            }
        }
        static System.ClientModel.ApiKeyCredential AzureOpenAIKey {
            get {
                string azureOpenAIKey = GetEnvironmentVariable("AZURE_OPENAI_API_KEY", IsDeveloperMode);
                if(string.IsNullOrEmpty(azureOpenAIKey))
                    azureOpenAIKey = "DEMO"; // Demo key
                return new System.ClientModel.ApiKeyCredential(azureOpenAIKey);
            }
        }
        static bool IsDeveloperMode => string.Equals(AssemblyInfo.Version, $"{AssemblyInfo.VersionShort}.0.0", StringComparison.InvariantCultureIgnoreCase);

        static string GetEnvironmentVariable(string variableName, bool allowSetNewEnvironmentVariable = false) {
            string environmentVariable = SafeEnvironment.GetEnvironmentVariable(variableName, EnvironmentVariableTarget.User);
            if(string.IsNullOrEmpty(environmentVariable) && allowSetNewEnvironmentVariable) {
                environmentVariable = XtraInputBox.Show($"Please enter {variableName} variable.", variableName, string.Empty);
                if(string.IsNullOrEmpty(environmentVariable))
                    Environment.Exit(0);
                SafeEnvironment.SetEnvironmentVariable(variableName, environmentVariable, EnvironmentVariableTarget.User);
            }
            return environmentVariable;
        }
    }
    //WA for https://github.com/Azure/azure-sdk-for-net/issues/45618
    class PromoteHttpStatusErrorsPipelineTransport : HttpClientPipelineTransport {
        protected override PipelineMessage CreateMessageCore() {
            var message = base.CreateMessageCore();
            return new DemoPipelineMessage(message.Request);
        }
        protected override void OnReceivedResponse(PipelineMessage message, HttpResponseMessage httpResponse) {
            if(!httpResponse.IsSuccessStatusCode) {
                if((int)httpResponse.StatusCode == 429) {
                    string seconds = httpResponse.Headers.GetValues("Retry-After").FirstOrDefault();
                    string text = $"You have reached the demo request limit. Your request will be retried automatically in {seconds} seconds. Thank you for your patience and understanding.";

                    Form.ActiveForm?.Invoke(new Action(() => {
                        var result = XtraMessageBox.Show(Form.ActiveForm, text, "AI Service Request Limit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if(result == DialogResult.Cancel)
                            (message as DemoPipelineMessage)?.Cancel();
                    }));
                }
                else {
                    throw new HttpRequestException("HTTP request failed with status code: " + httpResponse.StatusCode);
                }
            }
            base.OnReceivedResponse(message, httpResponse);
        }

        class DemoPipelineMessage : PipelineMessage {
            readonly CancellationTokenSource cts = new CancellationTokenSource();
            public DemoPipelineMessage(PipelineRequest request) : base(request) {
                CancellationToken = cts.Token;
            }
            public void Cancel() => cts.Cancel();
        }
    }
}
