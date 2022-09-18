using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace HamburgerMenu.UserControls
{
    public partial class SubmenuTwo : UserControl
    {
        public SubmenuTwo()
        {
            InitializeComponent();
        }

        private void Close_SubmenuTwo_Click(object sender, RoutedEventArgs e)
        {
            // Start the SubmenuTwo Slide-Out Animation
            Storyboard sb = FindResource("SubmenuTwo_Exit") as Storyboard;
            sb.Begin();

            // Disable Menu Container
            SubmenuTwo_Container.IsEnabled = false;

            // Unselect Password Btn
            password_btn.IsSelected = false;

            // Unselect Notification Btn
            notification_btn.IsSelected = false;

            // Access the SubmenuOne UserControl Account Btn and Unselect it.
            if(Application.Current.MainWindow is MainWindow MW)
            {
                MW.SubmenuOne_UC.account_btn.IsSelected = false;
            }
        }
    }
}
