using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Windows;

namespace PhoneWallpaperCapture.UI.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string title = "Phone Wallpaper Capture - 手機桌布截圖輔助工具";

    [ObservableProperty]
    private string statusMessage = "準備就緒";

    public MainWindowViewModel() {
        TestCommand = new RelayCommand(ExecuteTestCommand);
    }

    public IRelayCommand TestCommand { get; }

    private void ExecuteTestCommand() {
        StatusMessage = $"目前時間：{DateTime.Now:yyyy-MM-dd HH:mm:ss}";
        MessageBox.Show("MVVM應用程式基礎架構已正確運作。", 
                       "測試成功", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}