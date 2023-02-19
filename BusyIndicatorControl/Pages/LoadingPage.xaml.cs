using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace BusyIndicatorControl.Pages
{
    public partial class LoadingPage : Page
    {
        readonly DispatcherTimer _dispatcherTimer= new DispatcherTimer();
        public LoadingPage()
        {
            InitializeComponent();

            _dispatcherTimer.Tick += dispatcherTimer_Tick;
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
        }

        private void dispatcherTimer_Tick(object? sender, EventArgs e)
        {
            if (Application.Current.MainWindow != null)
            {
                //((MainWindow)Application.Current.MainWindow).MainFrame.Navigate(new Uri("Pages/SignInPage.xaml", UriKind.RelativeOrAbsolute));
            }

            _dispatcherTimer.Stop();
        }
    }
}
