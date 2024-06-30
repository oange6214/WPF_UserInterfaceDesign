using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PageNavigationApp.Controls;

public class MenuBtn : RadioButton
{
    public static readonly DependencyProperty ButtonTextProperty = DependencyProperty.Register(
        nameof(ButtonText),
        typeof(string),
        typeof(MenuBtn),
        new PropertyMetadata(string.Empty)
        );

    public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register(
        nameof(ImageSource),
        typeof(ImageSource),
        typeof(MenuBtn),
        new PropertyMetadata(null)
        );

    static MenuBtn()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MenuBtn), new FrameworkPropertyMetadata(typeof(MenuBtn)));
    }

    public string ButtonText
    {
        get { return (string)GetValue(ButtonTextProperty); }
        set { SetValue(ButtonTextProperty, value); }
    }

    public ImageSource ImageSource
    {
        get { return (ImageSource)GetValue(ImageSourceProperty); }
        set { SetValue(ImageSourceProperty, value); }
    }
}