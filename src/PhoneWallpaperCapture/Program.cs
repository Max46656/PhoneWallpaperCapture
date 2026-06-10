using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PhoneWallpaperCapture.UI.Views;
using PhoneWallpaperCapture.UI.ViewModels;
using System.Windows;

namespace PhoneWallpaperCapture;

public class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        try {
            var host = CreateHostBuilder(args).Build();

            var app = host.Services.GetRequiredService<Application>();
            var mainWindow = host.Services.GetRequiredService<MainWindow>();

            app.Run(mainWindow);
        } catch (Exception ex){
            MessageBox.Show($"啟動失敗：{ex.Message}\n\n詳細錯誤：{ex}", 
                           "錯誤", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<Application, App>();
                services.AddTransient<MainWindowViewModel>();
                services.AddTransient<MainWindow>();
            });
}