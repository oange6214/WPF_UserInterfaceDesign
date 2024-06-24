using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace HamburgerMenu.UserControls
{
    public partial class TrackTwo : UserControl
    {
        public TrackTwo()
        {
            InitializeComponent();
        }

        //Start TrackTwo Open Indicator Animation
        public void Open_TrackTwo()
        {
            Storyboard sb = FindResource("TrackTwo_Open") as Storyboard;
            sb.Begin();
        }

        //Start TrackTwo Close Indicator Animation
        public void Close_TrackTwo()
        {
            Storyboard sb = FindResource("TrackTwo_Close") as Storyboard;
            sb.Begin();
        }
    }
}
