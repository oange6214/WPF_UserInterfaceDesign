using System;
using System.Windows;

namespace MenuWithSubMenu
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainWindowFrame.Navigate(new Uri(string.Format("Pages/Dashboard.xaml"), UriKind.RelativeOrAbsolute));
        }
    }
}
