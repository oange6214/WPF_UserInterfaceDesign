using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Dashboard.FlatSales.UserControls
{
    public partial class UserCard : UserControl
    {
        public UserCard()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(string), typeof(UserCard));

        public string UpPrice
        {
            get { return (string)GetValue(UpPriceProperty); }
            set { SetValue(UpPriceProperty, value); }
        }

        public static readonly DependencyProperty UpPriceProperty =
            DependencyProperty.Register(nameof(UpPrice), typeof(string), typeof(UserCard));

        public string DownPrice
        {
            get { return (string)GetValue(DownPriceProperty); }
            set { SetValue(DownPriceProperty, value); }
        }

        public static readonly DependencyProperty DownPriceProperty =
            DependencyProperty.Register(nameof(DownPrice), typeof(string), typeof(UserCard));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register(nameof(IsActive), typeof(bool), typeof(UserCard));

        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register(nameof(Image), typeof(ImageSource), typeof(UserCard));
    }
}
