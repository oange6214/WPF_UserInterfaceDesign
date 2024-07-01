using PageNavigationApp.Utilities;
using PageNavigationApp.Utilities.Mvvm.Input;
using System.Windows;

namespace PageNavigationApp.ViewModels;

public class MainVM : ViewModelBase
{
    private object _currentView;
    private bool _isPanelVisible;

    public MainVM()
    {
        ShowPanelCommand = new RelayCommand(ShowPanel);
        HidePanelCommand = new RelayCommand(HidePanel);
        HomeCommand = new RelayCommand<object>(Home);
        CustomersCommand = new RelayCommand<object>(Customer);
        ProductsCommand = new RelayCommand<object>(Product);
        OrdersCommand = new RelayCommand<object>(Order);
        TransactionsCommand = new RelayCommand<object>(Transaction);
        ShipmentsCommand = new RelayCommand<object>(Shipment);
        SettingsCommand = new RelayCommand<object>(Setting);
        CloseCommand = new RelayCommand(Close);
        MaxCommand = new RelayCommand<Window>(MaxNormal);

        // Startup Page
        CurrentView = new HomeVM();

        _isPanelVisible = false;
    }

    public IRelayCommand CloseCommand { get; init; }

    public object CurrentView
    {
        get => _currentView;
        set => SetProperty(ref _currentView, value);
    }

    public IRelayCommand CustomersCommand { get; init; }

    public IRelayCommand HidePanelCommand { get; init; }

    public IRelayCommand HomeCommand { get; init; }

    public bool IsPanelVisible
    {
        get => _isPanelVisible;
        set => SetProperty(ref _isPanelVisible, value);
    }

    public IRelayCommand MaxCommand { get; init; }
    public IRelayCommand OrdersCommand { get; init; }
    public IRelayCommand ProductsCommand { get; init; }
    public IRelayCommand SettingsCommand { get; init; }
    public IRelayCommand ShipmentsCommand { get; init; }
    public IRelayCommand ShowPanelCommand { get; init; }
    public IRelayCommand TransactionsCommand { get; init; }

    public void HidePanel()
    {
        IsPanelVisible = false;
    }

    public void ShowPanel()
    {
        IsPanelVisible = true;
    }

    private void Close()
    {
        Application.Current.Shutdown();
    }

    private void Customer(object obj) => CurrentView = new CustomerVM();

    private void Home(object obj) => CurrentView = new HomeVM();

    private void MaxNormal(Window window)
    {
        window.WindowState = window.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
    }

    private void Order(object obj) => CurrentView = new OrderVM();

    private void Product(object obj) => CurrentView = new ProductVM();

    private void Setting(object obj) => CurrentView = new SettingVM();

    private void Shipment(object obj) => CurrentView = new ShipmentVM();

    private void Transaction(object obj) => CurrentView = new TransactionVM();
}