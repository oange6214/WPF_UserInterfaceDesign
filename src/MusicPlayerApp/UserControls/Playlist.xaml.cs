using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MusicPlayerApp.UserControls
{

    public partial class Playlist : UserControl
    {
        public Playlist()
        {
            InitializeComponent();
        }


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(string), typeof(Playlist));

        public string Desc
        {
            get { return (string)GetValue(DescProperty); }
            set { SetValue(DescProperty, value); }
        }

        public static readonly DependencyProperty DescProperty =
            DependencyProperty.Register(nameof(Desc), typeof(string), typeof(Playlist));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveeProperty); }
            set { SetValue(IsActiveeProperty, value); }
        }

        public static readonly DependencyProperty IsActiveeProperty =
            DependencyProperty.Register(nameof(IsActive), typeof(bool), typeof(Playlist));


        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register(nameof(Image), typeof(ImageSource), typeof(Playlist));

    }
}
