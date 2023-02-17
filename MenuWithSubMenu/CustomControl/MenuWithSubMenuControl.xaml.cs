using MenuWithSubMenu.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace MenuWithSubMenu.CustomControl
{
    public partial class MenuWithSubMenuControl : UserControl
    {
        public MenuWithSubMenuControl()
        {
            InitializeComponent();
            
            // Binding our ViewModel with the datacontext to read the Menu & SubMenuItemsData
            DataContext = new SideMenuViewModel();
        }

        public Thickness SubMenuPadding
        {
            get { return (Thickness)GetValue(SubMenuPaddingProperty); }
            set { SetValue(SubMenuPaddingProperty, value); }
        }

        public static readonly DependencyProperty SubMenuPaddingProperty =
            DependencyProperty.Register(nameof(SubMenuPadding), typeof(Thickness), typeof(MenuWithSubMenuControl));


        public bool HasIcon
        {
            get { return (bool)GetValue(HasIconProperty); }
            set { SetValue(HasIconProperty, value); }
        }

        public static readonly DependencyProperty HasIconProperty =
            DependencyProperty.Register(nameof(HasIcon), typeof(bool), typeof(MenuWithSubMenuControl));

    }
}
