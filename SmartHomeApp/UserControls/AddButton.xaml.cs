using System.Windows;
using System.Windows.Controls;

namespace SmartHomeApp.UserControls
{
    public partial class AddButton : UserControl
    {
        public AddButton()
        {
            InitializeComponent();
        }


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(string), typeof(AddButton));
    }
}
