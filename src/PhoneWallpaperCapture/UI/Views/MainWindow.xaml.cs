using System.Windows;
using PhoneWallpaperCapture.UI.ViewModels;

namespace PhoneWallpaperCapture.UI.Views;

public partial class MainWindow : Window
{
    public MainWindow(MainWindowViewModel viewModel) {
        InitializeComponent();
        DataContext = viewModel;
    }
}