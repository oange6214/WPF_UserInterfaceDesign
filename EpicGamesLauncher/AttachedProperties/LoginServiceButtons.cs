﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EpicGamesLauncher.AttachedProperties
{
    public class LoginServiceButtons : Button
    {

        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }

        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register(nameof(IconHeight), typeof(double), typeof(LoginServiceButtons));

        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register(nameof(IconWidth), typeof(double), typeof(LoginServiceButtons));

        public PathGeometry Icon
        {
            get { return (PathGeometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(Icon), typeof(PathGeometry), typeof(LoginServiceButtons));

        public ImageSource ImageIcon
        {
            get { return (ImageSource)GetValue(ImageIconProperty); }
            set { SetValue(ImageIconProperty, value); }
        }

        public static readonly DependencyProperty ImageIconProperty =
            DependencyProperty.Register(nameof(ImageIcon), typeof(ImageSource), typeof(LoginServiceButtons));

        public Brush IconFill
        {
            get { return (Brush)GetValue(IconFillProperty); }
            set { SetValue(IconFillProperty, value); }
        }

        public static readonly DependencyProperty IconFillProperty =
            DependencyProperty.Register(nameof(IconFill), typeof(Brush), typeof(LoginServiceButtons));

        public Brush IconFillOnHover
        {
            get { return (Brush)GetValue(IconFillOnHoverProperty); }
            set { SetValue(IconFillOnHoverProperty, value); }
        }

        public static readonly DependencyProperty IconFillOnHoverProperty =
            DependencyProperty.Register(nameof(IconFillOnHover), typeof(Brush), typeof(LoginServiceButtons));

        public Brush IconBackground
        {
            get { return (Brush)GetValue(IconBackgroundProperty); }
            set { SetValue(IconBackgroundProperty, value); }
        }

        public static readonly DependencyProperty IconBackgroundProperty =
            DependencyProperty.Register(nameof(IconBackground), typeof(Brush), typeof(LoginServiceButtons));

        public Brush IconBackgroundHover
        {
            get { return (Brush)GetValue(IconBackgroundHoverProperty); }
            set { SetValue(IconBackgroundHoverProperty, value); }
        }

        public static readonly DependencyProperty IconBackgroundHoverProperty =
            DependencyProperty.Register(nameof(IconBackgroundHover), typeof(Brush), typeof(LoginServiceButtons));

    }
}
