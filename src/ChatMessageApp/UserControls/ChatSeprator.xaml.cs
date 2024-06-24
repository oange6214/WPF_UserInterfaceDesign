using System.Windows;
using System.Windows.Controls;

namespace ChatMessageApp.UserControls
{
    public partial class ChatSeprator : UserControl
    {
        public ChatSeprator()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(string), typeof(ChatSeprator));

    }
}
