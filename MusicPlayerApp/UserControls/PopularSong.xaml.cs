using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MusicPlayerApp.UserControls
{
    public partial class PopularSong : UserControl
    {
        public PopularSong()
        {
            InitializeComponent();
        }


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(string), typeof(PopularSong));

        public string Time
        {
            get { return (string)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }

        public static readonly DependencyProperty TimeProperty =
            DependencyProperty.Register(nameof(Time), typeof(string), typeof(PopularSong));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveeProperty); }
            set { SetValue(IsActiveeProperty, value); }
        }

        public static readonly DependencyProperty IsActiveeProperty =
            DependencyProperty.Register(nameof(IsActive), typeof(bool), typeof(PopularSong));


        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register(nameof(Image), typeof(ImageSource), typeof(PopularSong));

    }
}
