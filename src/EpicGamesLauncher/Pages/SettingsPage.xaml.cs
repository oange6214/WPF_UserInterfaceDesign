using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

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

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            if (((Hyperlink)e.Source).Inlines.FirstOrDefault() is Run run && !run.Text.Contains("Logs"))
            {
                Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
            }
            else
            {
                Process.Start(new ProcessStartInfo($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\EpicGamesLauncher\Saved\Logs"));
            }

            e.Handled = true;
        }
    }
}
