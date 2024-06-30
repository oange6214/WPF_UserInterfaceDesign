using PageNavigationApp.Models;
using PageNavigationApp.Utilities;

namespace PageNavigationApp.ViewModels;

public class ProductVM : ViewModelBase
{
    private readonly PageModel _pageModel;

    public string ProductAvailability
    {
        get => _pageModel.ProductStatus;
        set => SetProperty(_pageModel.ProductStatus, value, newValue => _pageModel.ProductStatus = newValue);
    }

    public ProductVM()
    {
        _pageModel = new PageModel();
        ProductAvailability = "Out of Stock";
    }
}