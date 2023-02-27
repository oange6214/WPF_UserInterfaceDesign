using System;
using System.Windows;
using System.Windows.Controls;

namespace EpicGamesLauncher.Pages
{
    public partial class StorePage : Page
    {
        public StorePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow main)
            {
                main.MainFrame.Navigate(new Uri("../Pages/SignInPage.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void BtnSetting_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow main)
            {
                main.MainFrame.Navigate(new Uri("../Pages/SettingsPage.xaml", UriKind.RelativeOrAbsolute));
            }
        }
    }
}
