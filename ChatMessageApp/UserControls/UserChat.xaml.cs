﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChatMessageApp.UserControls
{
    public partial class UserChat : UserControl
    {
        public UserChat()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register(nameof(Username), typeof(string), typeof(UserChat));


        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register(nameof(Image), typeof(ImageSource), typeof(UserChat));

    }
}
