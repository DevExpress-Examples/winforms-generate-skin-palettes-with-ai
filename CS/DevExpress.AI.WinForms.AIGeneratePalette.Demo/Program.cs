using System;
using DevExpress.AI.WinForms.AIGeneratePalette.Demo.AI;
using DevExpress.AI.WinForms.AIGeneratePalette.Demo.Infrastructure;
using DevExpress.AI.WinForms.AIGeneratePalette.Persistence;
using DevExpress.AIIntegration;
using DevExpress.XtraBars.Helpers;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DevExpress.AI.WinForms.AIGeneratePalette.Demo {
    internal static class Program {       
            /// <summary>
            /// Main application entry point: obtains AI chat client via factory, registers AI extension, and loads persisted palettes.
            /// </summary>
            [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create a chat client (the model name can vary).
            IChatClient chatClient = ChatClientFactory.Create("demo");

            // Register the chat client and the palette generation extension in the DevExpress AI container.
            var defaultContainer = AIExtensionsContainerDesktop.Default;
            defaultContainer.RegisterChatClient(chatClient);
            defaultContainer.Register<GeneratePaletteRequest, GeneratePaletteExtension>();

            // Restore previously saved user AI palettes.
            AIPaletteRepository.LoadAIPalettes(Properties.Settings.Default.CustomPalettes_JSON);

            SkinHelper.CustomizeGalleryItemGroup += (s, e) => {
                var group = e.GalleryItemGroup;
                if(Equals(group.Tag, DevExpress.Skins.SkinCategory.SVG))
                    return;
                group.Visible = false;
            };

            var host = CreateHostBuilder().Build();
            Application.Run(new AccordionShellForm(host.Services));
        }

        static IHostBuilder CreateHostBuilder() {
            var builder = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<Views.DataGridView>();
                    services.AddTransient<Views.EmployeeView>();
                    services.AddSingleton<ICommonDataService>(new DataService());
                });
            return builder;
        }
    }
}
