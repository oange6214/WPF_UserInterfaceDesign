using System.Windows;
using System.Windows.Input;

namespace RegistraionPage
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void CloseWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void MinimizeWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
