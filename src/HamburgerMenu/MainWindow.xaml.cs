using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace HamburgerMenu
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Move / Drag the window.
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        // Change Window State to Maximized / Normal on Mouse Double Click.
        private void ChangeWindowState()
        {
            if(WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                Window_Edge.Visibility = Visibility.Collapsed;
            }
            else
            {
                if(WindowState == WindowState.Maximized)
                { 
                    this.WindowState = WindowState.Normal;
                    Window_Edge.Visibility = Visibility.Visible;
                }
            }
        }

        // Change Window State on Left Mouse Button Double Click.
        private void Main_Window_Panel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                ChangeWindowState();
            }

            // Close All Open Menu Panels on Mouse Button Click
            if(e.ChangedButton== MouseButton.Left && e.ClickCount == 1)
            {
                // Start the SubmenuTwo Slide-Out Animation
                Storyboard sb = FindResource("SubmenuTwo_Exit") as Storyboard;
                sb.Begin();

                // Access the SubmenuOne UserControl Account Btn and Unselect it.
                if(Application.Current.MainWindow is MainWindow MW)
                {
                    MW.SubmenuOne_UC.account_btn.IsSelected = false;
                }


                // Start the SubmenuOne Slide-Out Animation
                Storyboard sb1 = FindResource("SubmenuOne_Exit") as Storyboard;
                sb1.Begin();

                // Access the MainMenu UserControl Menu Toggle Btn and Uncheck it.
                if(Application.Current.MainWindow is MainWindow MW1)
                {
                    MW1.MainMenu_UC.Menu_ToggleButton.IsChecked = false;
                }

                // Access the SidePanel UserControl Mail Btn and Unselect it.
                if(Application.Current.MainWindow is MainWindow MW2)
                {
                    MW2.MainMenu_UC.SidePanel_UC.mail_sidepanel_listboxitem.IsSelected = false;
                }
            }
        }

        //Enable Main Window
        private void EnableMainWindow(object sender, EventArgs e)
        {
            this.IsEnabled = true;
        }

    }
}
