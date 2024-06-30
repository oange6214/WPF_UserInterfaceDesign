using PageNavigationApp.Utilities;
using PageNavigationApp.Utilities.Mvvm.Input;
using System.Windows;

namespace PageNavigationApp.ViewModels;

public class NavigationVM : ViewModelBase
{
    private object _currentView;

    public object CurrentView
    {
        get => _currentView;
        set => SetProperty(ref _currentView, value);
    }

    public IRelayCommand HomeCommand { get; set; }
    public IRelayCommand CustomersCommand { get; set; }
    public IRelayCommand ProductsCommand { get; set; }
    public IRelayCommand OrdersCommand { get; set; }
    public IRelayCommand TransactionsCommand { get; set; }
    public IRelayCommand ShipmentsCommand { get; set; }
    public IRelayCommand SettingsCommand { get; set; }
    public IRelayCommand CloseCommand { get; set; }

    private void Home(object obj) => CurrentView = new HomeVM();

    private void Customer(object obj) => CurrentView = new CustomerVM();

    private void Product(object obj) => CurrentView = new ProductVM();

    private void Order(object obj) => CurrentView = new OrderVM();

    private void Transaction(object obj) => CurrentView = new TransactionVM();

    private void Shipment(object obj) => CurrentView = new ShipmentVM();

    private void Setting(object obj) => CurrentView = new SettingVM();

    private void Close()
    {
        Application.Current.Shutdown();
    }

    public NavigationVM()
    {
        HomeCommand = new RelayCommand<object>(Home);
        CustomersCommand = new RelayCommand<object>(Customer);
        ProductsCommand = new RelayCommand<object>(Product);
        OrdersCommand = new RelayCommand<object>(Order);
        TransactionsCommand = new RelayCommand<object>(Transaction);
        ShipmentsCommand = new RelayCommand<object>(Shipment);
        SettingsCommand = new RelayCommand<object>(Setting);
        CloseCommand = new RelayCommand(Close);

        // Startup Page
        CurrentView = new HomeVM();
    }
}