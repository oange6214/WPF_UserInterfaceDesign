using System.Windows.Input;

namespace Dashborad.Modern.Inputs;

/// <summary>
/// RelayCommand allows you to inject the command's logic via delegates passed into its contructor. This method
/// enables ViewModel classes to implement commands in a concise manner.
/// </summary>

public class RelayCommand : ICommand
{
    private Func<object, bool> _canExecute;
    private Action<object> _execute;

    public RelayCommand(Action<object> execute)
    {
        _execute = execute;
        _canExecute = null;
    }

    public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
    {
        _execute = execute;
        _canExecute = canExecute;
    }

    public event EventHandler CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    public bool CanExecute(object? parameter)
    {
        return _canExecute == null || _canExecute(parameter);
    }

    public void Execute(object? parameter)
    {
        _execute(parameter);
    }
}