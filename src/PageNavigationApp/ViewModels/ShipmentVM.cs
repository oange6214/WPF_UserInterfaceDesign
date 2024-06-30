using PageNavigationApp.Models;
using PageNavigationApp.Utilities;

namespace PageNavigationApp.ViewModels;

public class ShipmentVM : ViewModelBase
{
    private readonly PageModel _pageModel;

    public TimeOnly ShipmentTracking
    {
        get => _pageModel.ShipmentDelivery;
        set => SetProperty(_pageModel.ShipmentDelivery, value, newValue => _pageModel.ShipmentDelivery = newValue);
    }

    public ShipmentVM()
    {
        _pageModel = new PageModel();
        ShipmentTracking = TimeOnly.FromDateTime(DateTime.Now);
    }
}