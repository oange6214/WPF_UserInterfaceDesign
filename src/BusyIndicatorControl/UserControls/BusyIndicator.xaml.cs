using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace BusyIndicatorControl.UserControls
{
    public partial class BusyIndicator : UserControl
    {
        public BusyIndicator()
        {
            InitializeComponent();
        }


        private double _progressValue;
        public double ProgressValue
        {
            get { return _progressValue; }
            set 
            { 
                SetPercent(ProgressBar, value); _progressValue = value; 
            }
        }

        static TimeSpan durationSpen = TimeSpan.FromMilliseconds(200);
        static void SetPercent(ProgressBar progressBar, double percentage)
        {
            DoubleAnimation animation = new(percentage, durationSpen);
            progressBar.BeginAnimation(RangeBase.ValueProperty, animation);
        }


        /// <summary>
        /// 顯示/隱藏
        /// </summary>
        public Visibility ProgressBarVisibility
        {
            get { return (Visibility)GetValue(ProgressBarVisibilityProperty); }
            set { SetValue(ProgressBarVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ProgressBarVisibilityProperty =
            DependencyProperty.Register(nameof(ProgressBarVisibility), typeof(Visibility), typeof(BusyIndicator));

        /// <summary>
        /// 前景色
        /// </summary>
        public SolidColorBrush ProgressForeground
        {
            get { return (SolidColorBrush)GetValue(ProgressForegroundProperty); }
            set { SetValue(ProgressForegroundProperty, value); }
        }

        public static readonly DependencyProperty ProgressForegroundProperty =
            DependencyProperty.Register(nameof(ProgressForeground), typeof(SolidColorBrush), typeof(BusyIndicator));

        /// <summary>
        /// 背景色
        /// </summary>
        public SolidColorBrush ProgressBackground
        {
            get { return (SolidColorBrush)GetValue(ProgressBackgroundProperty); }
            set { SetValue(ProgressBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ProgressBackgroundProperty =
            DependencyProperty.Register(nameof(ProgressBackground), typeof(SolidColorBrush), typeof(BusyIndicator));

        /// <summary>
        /// 取得或設定 ProgressBar 是否顯示實際值或泛型連續回應。
        /// 當這個屬性為 true 時，會 ProgressBar 以連續的方式動畫顯示一些橫條移動 ProgressBar ，並忽略 Value 屬性。
        /// </summary>
        public bool ProgressIsIndeterminate
        {
            get { return (bool)GetValue(ProgressIsIndeterminateProperty); }
            set { SetValue(ProgressIsIndeterminateProperty, value); }
        }

        public static readonly DependencyProperty ProgressIsIndeterminateProperty =
            DependencyProperty.Register(nameof(ProgressIsIndeterminate), typeof(bool), typeof(BusyIndicator));

        /// <summary>
        /// 圖片來源
        /// </summary>
        public Uri ItemSource
        {
            get { return (Uri)GetValue(ItemSourceProperty); }
            set { SetValue(ItemSourceProperty, value); }
        }

        public static readonly DependencyProperty ItemSourceProperty =
            DependencyProperty.Register(nameof(ItemSource), typeof(Uri), typeof(BusyIndicator));

        /// <summary>
        /// 文字
        /// </summary>
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(BusyIndicator));
    }
}
