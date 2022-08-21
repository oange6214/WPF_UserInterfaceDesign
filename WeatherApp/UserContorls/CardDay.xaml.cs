using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WeatherApp.UserContorls
{
    public partial class CardDay : UserControl
    {
        public CardDay()
        {
            InitializeComponent();
        }

        public string Day
        {
            get { return (string)GetValue(DayProperty); }
            set { SetValue(DayProperty, value); }
        }
        public static readonly DependencyProperty DayProperty =
            DependencyProperty.Register(nameof(Day), typeof(string), typeof(CardDay));

        public string MaxNum
        {
            get { return (string)GetValue(MaxNumProperty); }
            set { SetValue(MaxNumProperty, value); }
        }
        public static readonly DependencyProperty MaxNumProperty =
            DependencyProperty.Register(nameof(MaxNum), typeof(string), typeof(CardDay));

        public string MinNum
        {
            get { return (string)GetValue(MinNumProperty); }
            set { SetValue(MinNumProperty, value); }
        }
        public static readonly DependencyProperty MinNumProperty =
            DependencyProperty.Register(nameof(MinNum), typeof(string), typeof(CardDay));

        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register(nameof(Source), typeof(ImageSource), typeof(CardDay));

    }
}
