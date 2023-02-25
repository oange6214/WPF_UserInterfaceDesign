using EpicGamesLauncher;
using System;
using System.Windows;
using System.Windows.Controls;

namespace BusyIndicatorControl.Pages
{
    public partial class SignInPage : Page
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if ((Application.Current.MainWindow != null))
            {
                ((MainWindow)Application.Current.MainWindow).MainFrame.Navigate(
                    new Uri("../Pages/PreparingToLaunchPage.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((Application.Current.MainWindow != null))
            {
                ((MainWindow)Application.Current.MainWindow).MainFrame.Navigate(
                    new Uri("../Pages/SettingsPage.xaml", UriKind.RelativeOrAbsolute));
            }
        }
    }
}
