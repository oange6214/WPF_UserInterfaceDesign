using System.Windows;
using System.Windows.Input;

namespace LoginFlatLight;

public partial class MainWindow : Window
{
    private bool IsMaximize = false;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void Border_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            DragMove();
        }
    }

    private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ClickCount == 2)
        {
            if (IsMaximize)
            {
                WindowState = WindowState.Normal;
                Width = 1024;
                Height = 720;

                IsMaximize = false;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }
    }
}