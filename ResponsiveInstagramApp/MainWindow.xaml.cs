using System.Windows;

namespace ResponsiveInstagramApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textSearch_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            textSearch.Visibility = !string.IsNullOrEmpty(txtSearch.Text) && txtSearch.Text.Length > 0
                ? Visibility.Collapsed
                : Visibility.Visible;
        }
    }
}
