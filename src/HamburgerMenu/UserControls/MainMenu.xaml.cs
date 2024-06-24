using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace HamburgerMenu.UserControls
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        // Reset / Restart the application
        private void Rest_Control_Click(object sender, RoutedEventArgs e)
        {
            var currentExecutablePath = Process.GetCurrentProcess().MainModule.FileName;
            Process.Start(currentExecutablePath);
            Application.Current.Shutdown();
        }
    }
}
