using System.Windows;
using System.Windows.Controls;

namespace ChatMessageApp.UserControls
{
    public partial class MyMessageChat : UserControl
    {
        public MyMessageChat()
        {
            InitializeComponent();
        }

        public string Message
        {
            get { return (string)GetValue(MessageeProperty); }
            set { SetValue(MessageeProperty, value); }
        }

        public static readonly DependencyProperty MessageeProperty =
            DependencyProperty.Register(nameof(Message), typeof(string), typeof(MyMessageChat));

    }
}
