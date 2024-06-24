using System.Windows;
using System.Windows.Controls;

namespace EpicGamesLauncher.AttachedProperties
{
    public class SideNavigationMenu : UserControl
    {

        public object MenuButtonsContiner
        {
            get => GetValue(MenuButtonsContinerProperty);
            set => SetValue(MenuButtonsContinerProperty, value); 
        }

        public static readonly DependencyProperty MenuButtonsContinerProperty =
            DependencyProperty.Register(nameof(MenuButtonsContiner), typeof(object), typeof(SideNavigationMenu));


        public object FooterMenuButtonsContainer
        {
            get => GetValue(FooterMenuButtonsContainerProperty);
            set => SetValue(FooterMenuButtonsContainerProperty, value);
        }

        public static readonly DependencyProperty FooterMenuButtonsContainerProperty =
            DependencyProperty.Register(nameof(FooterMenuButtonsContainer), typeof(object), typeof(SideNavigationMenu));

    }
}
