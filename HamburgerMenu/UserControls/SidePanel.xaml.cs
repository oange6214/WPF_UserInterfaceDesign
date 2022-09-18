using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace HamburgerMenu.UserControls
{
    public partial class SidePanel : UserControl
    {
        public SidePanel()
        {
            InitializeComponent();
        }

        private void mail_sidepanel_listboxitem_Selected(object sender, RoutedEventArgs e)
        {
            // Start the SubmenuOne Slide-In Animation
            Storyboard sb = FindResource("SubmenuOne_Enter") as Storyboard;
            sb.Begin();

            // Access the SubmenuOne UserControl Menu Panel and Enable it.
            if( Application.Current.MainWindow is MainWindow MW)
            {
                MW.SubmenuOne_UC.Menu_Panel.IsEnabled = true;
            }

            //TrackOne Enter Indicator
            if(Application.Current.MainWindow is MainWindow MW1)
            {
                MW1.Track_One.Open_TrackOne();
            }
        }

        private void mail_sidepanel_listboxitem_Unselected(object sender, RoutedEventArgs e)
        {
            // Start the SubmenuOne Slide-Out Animation
            Storyboard sb = FindResource("SubmenuOne_Exit") as Storyboard;
            sb.Begin();

            //TrackOne Exit Indicator
            if (Application.Current.MainWindow is MainWindow MW2)
            {
                MW2.Track_One.Close_TrackOne();
            }
        }
    }
}
