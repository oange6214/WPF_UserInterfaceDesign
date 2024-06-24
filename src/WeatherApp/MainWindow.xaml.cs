﻿using System.Windows;
using System.Windows.Input;

namespace WeatherApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void textSearch_MouseDown(object sender, MouseButtonEventArgs e)
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
