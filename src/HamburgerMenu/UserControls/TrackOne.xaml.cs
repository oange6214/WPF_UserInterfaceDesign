using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace HamburgerMenu.UserControls
{
    public partial class TrackOne : UserControl
    {
        public TrackOne()
        {
            InitializeComponent();
        }

        //Start TrackOne Open Indicator Animation
        public void Open_TrackOne()
        {
            Storyboard sb = FindResource("TrackOne_Open") as Storyboard;
            sb.Begin();
        }

        //Start TrackOne Close Indicator Animation
        public void Close_TrackOne()
        {
            Storyboard sb = FindResource("TrackOne_Close") as Storyboard;
            sb.Begin();
        }
    }
}
