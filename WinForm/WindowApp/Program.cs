using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;
using WinForm.WindowApp.Hosting;
using WinForm.WindowApp.Services;
using WinForm.WindowApp.Views;

namespace WinForm.WindowApp
{
    public static class Program
    {
        [STAThread]
        public static async Task Main(string[] args)
        {
            await CreateHostBuilder(args).Build().RunAsync();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWinForms<MainWindow>()
                .ConfigureServices(ConfigureServices);

        private static void ConfigureServices(HostBuilderContext hostBuilderContext,
                                              IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<WindowService>()
                .AddTransient<DialogService>()
                .AddTransient<MainWindow>()
                .AddTransient<Window1>()
                .AddTransient<Window2>()
                .AddTransient<Window3>()
                .AddTransient<Window4>()
                .AddTransient<Window5>()
                .AddScoped<MyService>();
        }
    }
}
