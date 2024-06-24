using MahApps.Metro.IconPacks;
using System.Windows;
using System.Windows.Controls;

namespace Dashboard.Recruitment.UserControls
{
    public partial class InfoCard : UserControl
    {
        public InfoCard()
        {
            InitializeComponent();
        }


        public string Titile
        {
            get { return (string)GetValue(TitileProperty); }
            set { SetValue(TitileProperty, value); }
        }

        public static readonly DependencyProperty TitileProperty =
            DependencyProperty.Register(nameof(Titile), typeof(string), typeof(InfoCard));

        public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register(nameof(Number), typeof(string), typeof(InfoCard));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register(nameof(IsActive), typeof(bool), typeof(InfoCard));

        public bool IsTechnical
        {
            get { return (bool)GetValue(IsTechnicalProperty); }
            set { SetValue(IsTechnicalProperty, value); }
        }

        public static readonly DependencyProperty IsTechnicalProperty =
            DependencyProperty.Register(nameof(IsTechnical), typeof(bool), typeof(InfoCard));
    }
}
