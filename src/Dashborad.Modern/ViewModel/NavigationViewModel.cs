using Dashborad.Modern.Inputs;
using Dashborad.Modern.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Windows.Input;

namespace Dashborad.Modern.ViewModel;

public class NavigationViewModel : INotifyPropertyChanged
{
    // Back Button Command
    private ICommand _backHomeCommand;

    // Close Button Command
    private ICommand _closeCommand;

    // Text Search Filter
    private string _filterText;

    // Menu Button Command
    private ICommand _menuCommand;

    // This PC Button Command
    private ICommand _pcCommand;

    private object _selectedViewModel;

    // CollectionViewSource enables XAML code to set the commonly used CollectionView properties,
    // passing these settings to the underlying view.
    private CollectionViewSource MenuItemsCollection;

    public NavigationViewModel()
    {
        // ObservableCollection represents a dynamic data collection that provides notifications when items
        // get added, removed, or when the whole list is refreshed.
        ObservableCollection<MenuItems> menuItems =
        [
            new() { MenuName = "Home", MenuImage = @"/Assets/Images/Home_Icon.png" },
            new () { MenuName = "Desktop", MenuImage = @"/Assets/Images/Desktop_Icon.png" },
            new () { MenuName = "Documents", MenuImage = @"/Assets/Images/Document_Icon.png" },
            new () { MenuName = "Downloads", MenuImage = @"/Assets/Images/Download_Icon.png" },
            new () { MenuName = "Pictures", MenuImage = @"/Assets/Images/Images_Icon.png" },
            new () { MenuName = "Music", MenuImage = @"/Assets/Images/Music_Icon.png" },
            new () { MenuName = "Movies", MenuImage = @"/Assets/Images/Movies_Icon.png" },
            new () { MenuName = "Trash", MenuImage = @"/Assets/Images/Trash_Icon.png" },
        ];

        MenuItemsCollection = new CollectionViewSource { Source = menuItems };
        MenuItemsCollection.Filter += MenuItems_Filter;

        // Set Startup Page
        SelectedViewModel = new StartupViewModel();
    }

    // Implement interface member for INotifyPropertyChanged.
    public event PropertyChangedEventHandler? PropertyChanged;

    public ICommand BackHomeCommand
    {
        get
        {
            _backHomeCommand ??= new RelayCommand(param => ShowHome());
            return _backHomeCommand;
        }
    }

    public ICommand CloseAppCommand
    {
        get
        {
            _closeCommand ??= new RelayCommand(param => CloseApp(param));
            return _closeCommand;
        }
    }

    public string FilterText
    {
        get => _filterText;
        set
        {
            _filterText = value;
            MenuItemsCollection.View.Refresh();
            OnPropertyChanged();
        }
    }

    public ICommand MenuCommand
    {
        get
        {
            _menuCommand ??= new RelayCommand(param => SwitchViews(param));
            return _menuCommand;
        }
    }

    public ICommand PCCommand
    {
        get
        {
            _pcCommand ??= new RelayCommand(param => PCView());
            return _pcCommand;
        }
    }

    public object SelectedViewModel
    {
        get => _selectedViewModel;
        set
        {
            _selectedViewModel = value;
            OnPropertyChanged();
        }
    }

    // ICollectionView enalbes collections to have the functionalities of current record management,
    // custom sorting, filtering, and grouping.
    public ICollectionView SourceCollection => MenuItemsCollection.View;

    // Show PC View
    public void PCView()
    {
        SelectedViewModel = new PCViewModel();
    }

    // Swtich Views
    public void SwitchViews(object parameter)
    {
        switch (parameter)
        {
            case "Home":
                SelectedViewModel = new HomeViewModel();
                break;

            case "Desktop":
                SelectedViewModel = new DesktopViewModel();
                break;

            case "Documents":
                SelectedViewModel = new DocumentViewModel();
                break;

            case "Downloads":
                SelectedViewModel = new DownloadViewModel();
                break;

            case "Pictures":
                SelectedViewModel = new PictureViewModel();
                break;

            case "Music":
                SelectedViewModel = new MusicViewModel();
                break;

            case "Movies":
                SelectedViewModel = new MovieViewModel();
                break;

            case "Trash":
                SelectedViewModel = new TrashViewModel();
                break;
        }
    }

    // Close App
    private void CloseApp(object obj)
    {
        MainWindow win = obj as MainWindow;
        win.Close();
    }

    private void MenuItems_Filter(object sender, FilterEventArgs e)
    {
        if (string.IsNullOrEmpty(FilterText))
        {
            e.Accepted = true;
            return;
        }

        MenuItems _item = e.Item as MenuItems;
        if (_item.MenuName.ToUpper().Contains(FilterText.ToUpper()))
        {
            e.Accepted = true;
        }
        else
        {
            e.Accepted = false;
        }
    }

    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    // Show Home View
    private void ShowHome()
    {
        SelectedViewModel = new HomeViewModel();
    }
}