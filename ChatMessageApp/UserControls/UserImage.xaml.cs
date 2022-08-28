using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChatMessageApp.UserControls
{
    public partial class UserImage : UserControl
    {
        public UserImage()
        {
            InitializeComponent();
        }


        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register(nameof(Image), typeof(ImageSource), typeof(UserImage));
    }
}
