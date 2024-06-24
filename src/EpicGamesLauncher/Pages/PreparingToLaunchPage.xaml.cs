using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace EpicGamesLauncher.Pages
{
    public partial class PreparingToLaunchPage : Page
    {
        readonly DispatcherTimer _dispatcherTimer = new();

        public PreparingToLaunchPage()
        {
            InitializeComponent();

            _dispatcherTimer.Tick += DispatcherTimer_Tick;
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
            _dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object? sender, EventArgs e)
        {
            MainGrid.Height = 220;
            ProgressBar.Visibility = Visibility.Visible;

            _dispatcherTimer.Tick += DispatcherTimer_Tick1;
            _dispatcherTimer.Stop();
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            _dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick1(object? sender, EventArgs e)
        {
            if(Application.Current.MainWindow is MainWindow main)
            {
                main.MainFrame.Navigate(new Uri("Pages/StorePage.xaml", UriKind.RelativeOrAbsolute));
            }
            _dispatcherTimer.Stop();
        }
    }
}
