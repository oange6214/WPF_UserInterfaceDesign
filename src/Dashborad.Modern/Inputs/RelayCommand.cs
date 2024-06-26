using System.Windows.Input;

namespace Dashborad.Modern.Inputs;

/// <summary>
/// RelayCommand allows you to inject the command's logic via delegates passed into its contructor. This method
/// enables ViewModel classes to implement commands in a concise manner.
/// </summary>

public class RelayCommand : ICommand
{
    private Action<object> _execute;
    private Func<object, bool> _canExecute;

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter)
    {
        throw new NotImplementedException();
    }

    public void Execute(object? parameter)
    {
        throw new NotImplementedException();
    }
}