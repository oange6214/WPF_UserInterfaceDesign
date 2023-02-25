using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace EpicGamesLauncher.Pages
{
    public partial class LoadingPage : Page
    {
        DispatcherTimer _dispatcherTimer;
        public LoadingPage()
        {
            InitializeComponent();

            _dispatcherTimer = new();

            _dispatcherTimer.Tick += DispatcherTimer_Tick;
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            _dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object? sender, EventArgs e)
        {
            if (Application.Current.MainWindow != null)
            {
                ((MainWindow)Application.Current.MainWindow).MainFrame.Navigate(new Uri("Pages/SignInPage.xaml", UriKind.RelativeOrAbsolute));
            }
            _dispatcherTimer.Stop();
        }
    }
}
