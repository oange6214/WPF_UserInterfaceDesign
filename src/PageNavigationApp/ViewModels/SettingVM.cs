using PageNavigationApp.Models;
using PageNavigationApp.Utilities;

namespace PageNavigationApp.ViewModels;

public class SettingVM : ViewModelBase
{
    private readonly PageModel _pageModel;

    public bool Settings
    {
        get => _pageModel.LocationStatus;
        set => SetProperty(_pageModel.LocationStatus, value, newValue => _pageModel.LocationStatus = newValue);
    }

    public SettingVM()
    {
        _pageModel = new PageModel();
        Settings = true;
    }
}