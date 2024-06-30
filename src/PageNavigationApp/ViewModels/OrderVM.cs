using PageNavigationApp.Models;
using PageNavigationApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageNavigationApp.ViewModels;

public class OrderVM : ViewModelBase
{
    private readonly PageModel _pageModel;

    public DateOnly DisplayOrderDate
    {
        get => _pageModel.OrderDate;
        set => SetProperty(_pageModel.OrderDate, value, newValue => _pageModel.OrderDate = newValue);
    }

    public OrderVM()
    {
        _pageModel = new PageModel();
        DisplayOrderDate = DateOnly.FromDateTime(DateTime.Now);
    }
}