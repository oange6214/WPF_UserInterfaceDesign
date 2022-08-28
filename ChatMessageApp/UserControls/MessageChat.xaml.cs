using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChatMessageApp.UserControls
{
    public partial class MessageChat : UserControl
    {
        public MessageChat()
        {
            InitializeComponent();
        }

        public string Message
        {
            get { return (string)GetValue(MessageeProperty); }
            set { SetValue(MessageeProperty, value); }
        }

        public static readonly DependencyProperty MessageeProperty =
            DependencyProperty.Register(nameof(Message), typeof(string), typeof(MessageChat));


        public Brush Color
        {
            get { return (Brush)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register(nameof(Color), typeof(Brush), typeof(MessageChat));

    }
}
