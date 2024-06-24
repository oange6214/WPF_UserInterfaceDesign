using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EpicGamesLauncher.CustomControls
{
    public partial class LibraryItemCard : UserControl
    {
        public LibraryItemCard()
        {
            InitializeComponent();
        }

        public ImageSource ImageSource
        {
            get => (ImageSource)GetValue(ImageSourceProperty); 
            set => SetValue(ImageSourceProperty, value); 
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register(nameof(ImageSource), typeof(ImageSource), typeof(LibraryItemCard));

        public string Title
        {
            get => (string)GetValue(TitleProperty); 
            set => SetValue(TitleProperty, value); 
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(string), typeof(LibraryItemCard));

    }
}
