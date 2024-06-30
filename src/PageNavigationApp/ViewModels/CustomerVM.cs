using PageNavigationApp.Models;
using PageNavigationApp.Utilities;

namespace PageNavigationApp.ViewModels;

public class CustomerVM : ViewModelBase
{
    private readonly PageModel _pageModel;

    public int CustomerID
    {
        get => _pageModel.CustomerCount;
        set => SetProperty(_pageModel.CustomerCount, value, newValue => _pageModel.CustomerCount = newValue);
    }

    public CustomerVM()
    {
        _pageModel = new PageModel();
        CustomerID = 100528;
    }
}