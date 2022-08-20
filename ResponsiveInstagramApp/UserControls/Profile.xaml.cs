using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ResponsiveInstagramApp.UserControls
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }



        public int PaddingNum
        {
            get { return (int)GetValue(PaddingNumProperty); }
            set { SetValue(PaddingNumProperty, value); }
        }

        public static readonly DependencyProperty PaddingNumProperty =
            DependencyProperty.Register(nameof(PaddingNum), typeof(int), typeof(Profile));

        public int Size
        {
            get { return (int)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register(nameof(Size), typeof(int), typeof(Profile));



        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register(nameof(Source), typeof(ImageSource), typeof(Profile));
    }
}
