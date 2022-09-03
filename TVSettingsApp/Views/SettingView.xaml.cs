using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static TVSettingsApp.MainWindow;

namespace TVSettingsApp.Views
{
    public partial class SettingView : UserControl
    {
        private MainWindow window;

        public SettingView()
        {
            InitializeComponent();
        }

        private void LoadWindow()
        {
            if (window == null)
            {
                window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
            }
        }

        private void Element_ElementClick(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecuteView(AppViews.Network);
        }

        private void Element_ElementClick_1(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecuteView(AppViews.Time);
        }

        private void Element_ElementClick_2(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecuteView(AppViews.Storage);
        }

        private void Element_ElementClick_3(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecuteView(AppViews.About);
        }
    }
}
