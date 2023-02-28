using System;
using System.Windows;
using System.Windows.Controls;

namespace EpicGamesLauncher.Pages
{
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow main)
            {
                main.MainFrame.GoBack();
            }
        }
    }
}
