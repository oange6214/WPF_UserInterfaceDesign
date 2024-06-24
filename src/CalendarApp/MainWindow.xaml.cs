using System.Windows;
using System.Windows.Input;

namespace CalendarApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void lblNote_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtNote.Focus();
        }

        private void txtNote_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            lblNote.Visibility = !string.IsNullOrEmpty(txtNote.Text) && txtNote.Text.Length > 0 
                ? Visibility.Collapsed 
                : Visibility.Visible;
        }

        private void lblTime_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtTime.Focus();
        }

        private void txtTime_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            lblTime.Visibility = !string.IsNullOrEmpty(txtTime.Text) && txtTime.Text.Length > 0
                ? Visibility.Collapsed
                : Visibility.Visible;
        }
    }
}
