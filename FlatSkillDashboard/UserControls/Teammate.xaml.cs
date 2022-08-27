using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlatSkillDashboard.UserControls
{
    public partial class Teammate : UserControl
    {
        public Teammate()
        {
            InitializeComponent();
        }



        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(string), typeof(Teammate));

        public string Num
        {
            get { return (string) GetValue(NumProperty); }
            set { SetValue (NumProperty, value); }
        }
        public static readonly DependencyProperty NumProperty =
            DependencyProperty.Register(nameof(Num), typeof(string), typeof(Teammate));



        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register(nameof(Source), typeof(ImageSource), typeof(Teammate));


    }
}
