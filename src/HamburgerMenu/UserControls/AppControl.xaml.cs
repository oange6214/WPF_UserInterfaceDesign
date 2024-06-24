using System.Windows;
using System.Windows.Controls;

namespace HamburgerMenu.UserControls
{
    public partial class AppControl : UserControl
    {
        public AppControl()
        {
            InitializeComponent();
        }

        private void App_Minimize_Click(object sender, RoutedEventArgs e)
        {
            // App_Minimize the Window
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void App_Maximize_Click(object sender, RoutedEventArgs e)
        {
            // Maximize / Normal Window State
            if(Application.Current.MainWindow.WindowState == WindowState.Normal)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;

                // Top, Bottom Border Collapsed
                if(Application.Current.MainWindow is MainWindow MW)
                {
                    MW.Window_Edge.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;

                // Top, Bottom Border Visible
                if(Application.Current.MainWindow is MainWindow MW1)
                {
                    MW1.Window_Edge.Visibility = Visibility.Visible;
                }
            }
        }

        private void App_ShutDown_Click(object sender, RoutedEventArgs e)
        {
            // Close the Application
            Application.Current.MainWindow.Close();
        }
    }
}
