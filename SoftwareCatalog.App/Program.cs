using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SoftwareCatalog.App.Forms;
using SoftwareCatalog.CrossCutting.IoC;

namespace SoftwareCatalog.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                         .ConfigureAppConfiguration((context, builder) =>
                         {
                             builder.AddJsonFile("appsettings.json", optional: true);
                         })
                         .ConfigureServices((context, services) =>
                         {
                             ConfigureServices(services);
                         })
                         .ConfigureLogging(logging =>
                         {
                             // Add other loggers...
                         })
                         .Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = host.Services;
            var mainForm = services.GetRequiredService<DashBoardForm>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.Inject();
            services.AddSingleton<DashBoardForm>();
            services.AddSingleton<CadastroTableStorage>();            
        }
    }
}