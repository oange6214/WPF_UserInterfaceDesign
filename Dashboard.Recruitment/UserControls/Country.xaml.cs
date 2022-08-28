using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Dashboard.Recruitment.UserControls
{
    public partial class Country : UserControl
    {
        public Country()
        {
            InitializeComponent();
        }


        public string CountryName
        {
            get { return (string)GetValue(CountryNameProperty); }
            set { SetValue(CountryNameProperty, value); }
        }

        public static readonly DependencyProperty CountryNameProperty =
            DependencyProperty.Register(nameof(CountryName), typeof(string), typeof(Country));

        public string Price
        {
            get { return (string)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register(nameof(Price), typeof(string), typeof(Country));

        public bool IsLevelUp
        {
            get { return (bool)GetValue(IsLevelUpProperty); }
            set { SetValue(IsLevelUpProperty, value); }
        }

        public static readonly DependencyProperty IsLevelUpProperty =
            DependencyProperty.Register(nameof(IsLevelUp), typeof(bool), typeof(Country));

        public ImageSource Flag
        {
            get { return (ImageSource)GetValue(FlagProperty); }
            set { SetValue(FlagProperty, value); }
        }

        public static readonly DependencyProperty FlagProperty =
            DependencyProperty.Register(nameof(Flag), typeof(ImageSource), typeof(Country));
    }
}
