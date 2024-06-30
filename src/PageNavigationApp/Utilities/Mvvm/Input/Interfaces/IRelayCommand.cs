using System.Windows.Input;

namespace PageNavigationApp.Utilities.Mvvm.Input;

public interface IRelayCommand : ICommand
{
    void NotifyCanExecuteChanged();
}