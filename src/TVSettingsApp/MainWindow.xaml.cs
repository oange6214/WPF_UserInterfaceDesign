using System.Windows;
using System.Windows.Input;
using TVSettingsApp.Views;

namespace TVSettingsApp
{
    public partial class MainWindow : Window
    {
        public enum AppViews
        {
            About, Setting, Storage, Time, Network
        }

        /// <summary>
        /// Init all pages just one time
        /// </summary>
        private SettingView settingView = new SettingView();
        private AboutView aboutView = new AboutView();
        private StorageView storageView = new StorageView();
        private TimeView timeView = new TimeView();
        private NetworkView networkView = new NetworkView();

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

        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1280;
                    this.Height = 720;

                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximized = true;
                }
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            container.Content = settingView;
            backButton.Visibility = Visibility.Collapsed;
            titleText.Text = "Settings";
        }

        public void ExecuteView(AppViews view)
        {
            backButton.Visibility = Visibility.Visible;

            switch(view)
            {
                case AppViews.About:
                    container.Content = aboutView;
                    titleText.Text = "About Us";
                    break;
                case AppViews.Setting:
                    container.Content = settingView;
                    titleText.Text = "Settings";
                    break;
                case AppViews.Storage:
                    container.Content = storageView;
                    titleText.Text = "Storage";
                    break;
                case AppViews.Time:
                    container.Content = timeView;
                    titleText.Text = "Time Settings";
                    break;
                case AppViews.Network:
                    container.Content = networkView;
                    titleText.Text = "Network Settings";
                    break;
            }
        }
    }
}
