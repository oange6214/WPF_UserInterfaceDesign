using MahApps.Metro.IconPacks;
using System.Windows;
using System.Windows.Controls;

namespace Dashboard.Recruitment.UserControls
{
    public partial class MenuButton : UserControl
    {
        public MenuButton()
        {
            InitializeComponent();
        }


        public PackIconMaterialKind Icon
        {
            get { return (PackIconMaterialKind)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(Icon), typeof(PackIconMaterialKind), typeof(MenuButton));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register(nameof(IsActive), typeof(bool), typeof(MenuButton));

    }
}
