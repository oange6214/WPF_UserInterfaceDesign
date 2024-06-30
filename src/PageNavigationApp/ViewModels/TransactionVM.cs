using PageNavigationApp.Models;
using PageNavigationApp.Utilities;

namespace PageNavigationApp.ViewModels;

public class TransactionVM : ViewModelBase
{
    private readonly PageModel _pageModel;

    public decimal TransactionAmount
    {
        get => _pageModel.TransactionValue;
        set => SetProperty(_pageModel.TransactionValue, value, newValue => _pageModel.TransactionValue = newValue);
    }

    public TransactionVM()
    {
        _pageModel = new PageModel();
        TransactionAmount = 5648;
    }
}