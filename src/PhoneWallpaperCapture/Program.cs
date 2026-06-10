using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PhoneWallpaperCapture.UI.Views;
using System.Windows;

namespace PhoneWallpaperCapture;

public class Program
{
    [STAThread]
    public static void Main(string[] args) {
        var host = CreateHostBuilder(args).Build();
        
        var app = host.Services.GetRequiredService<Application>();
        app.Run(host.Services.GetRequiredService<MainWindow>());
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) => {
                services.AddSingleton<Application, App>();
                services.AddTransient<MainWindow>();
            });
}