﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EpicGamesLauncher.AttachedProperties
{
    public class BasicMenuButton : RadioButton
    {
        public PathGeometry Icon
        {
            get =>(PathGeometry)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(Icon), typeof(PathGeometry), typeof(BasicMenuButton));

        public double IconHeight
        {
            get =>(double)GetValue(IconHeightProperty);
            set => SetValue(IconHeightProperty, value);
        }

        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register(nameof(IconHeight), typeof(double), typeof(BasicMenuButton));

        public double IconWidth
        {
            get =>(double)GetValue(IconWidthProperty);
            set => SetValue(IconWidthProperty, value);
        }

        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register(nameof(IconWidth), typeof(double), typeof(BasicMenuButton));

        public ImageSource ImageIcon
        {
            get =>(ImageSource)GetValue(ImageIconProperty);
            set => SetValue(ImageIconProperty, value);
        }

        public static readonly DependencyProperty ImageIconProperty =
            DependencyProperty.Register(nameof(ImageIcon), typeof(ImageSource), typeof(BasicMenuButton));

        public Brush IconFill
        {
            get =>(Brush)GetValue(IconFillProperty);
            set => SetValue(IconFillProperty, value);
        }

        public static readonly DependencyProperty IconFillProperty =
            DependencyProperty.Register(nameof(IconFill), typeof(Brush), typeof(BasicMenuButton));

        public Brush IconFillOnHover
        {
            get =>(Brush)GetValue(IconFillOnHoverProperty);
            set => SetValue(IconFillOnHoverProperty, value);
        }

        public static readonly DependencyProperty IconFillOnHoverProperty =
            DependencyProperty.Register(nameof(IconFillOnHover), typeof(Brush), typeof(BasicMenuButton));

        public Brush IconBackground
        {
            get =>(Brush)GetValue(IconBackgroundProperty);
            set => SetValue(IconBackgroundProperty, value);
        }

        public static readonly DependencyProperty IconBackgroundProperty =
            DependencyProperty.Register(nameof(IconBackground), typeof(Brush), typeof(BasicMenuButton));

        public Brush IconBackgroundHover
        {
            get =>(Brush)GetValue(IconBackgroundHoverProperty);
            set => SetValue(IconBackgroundHoverProperty, value);
        }

        public static readonly DependencyProperty IconBackgroundHoverProperty =
            DependencyProperty.Register(nameof(IconBackgroundHover), typeof(Brush), typeof(BasicMenuButton));

    }
}
