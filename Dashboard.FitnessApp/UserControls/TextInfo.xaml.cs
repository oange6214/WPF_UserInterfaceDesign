﻿using System.Windows;
using System.Windows.Controls;

namespace Dashboard.FitnessApp.UserControls
{
    public partial class TextInfo : UserControl
    {
        public TextInfo()
        {
            InitializeComponent();
        }


        public string TextTop
        {
            get { return (string)GetValue(TextTopProperty); }
            set { SetValue(TextTopProperty, value); }
        }

        public static readonly DependencyProperty TextTopProperty =
            DependencyProperty.Register(nameof(TextTop), typeof(string), typeof(TextInfo));

        public string TextMiddle
        {
            get { return (string)GetValue(TextMiddleProperty); }
            set { SetValue(TextMiddleProperty, value); }
        }

        public static readonly DependencyProperty TextMiddleProperty =
            DependencyProperty.Register(nameof(TextMiddle), typeof(string), typeof(TextInfo));

        public string TextBottom
        {
            get { return (string)GetValue(TextBottomProperty); }
            set { SetValue(TextBottomProperty, value); }
        }

        public static readonly DependencyProperty TextBottomProperty =
            DependencyProperty.Register(nameof(TextBottom), typeof(string), typeof(TextInfo));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register(nameof(IsActive), typeof(bool), typeof(TextInfo));
    }
}
