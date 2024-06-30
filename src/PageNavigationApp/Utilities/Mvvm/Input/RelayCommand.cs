using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PageNavigationApp.Utilities.Mvvm.Input;

public sealed class RelayCommand : IRelayCommand
{
    private readonly Action execute;
    private readonly Func<bool>? canExecute;

    public event EventHandler? CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    public RelayCommand(Action execute)
    {
        ArgumentNullException.ThrowIfNull(execute);

        this.execute = execute;
    }

    public RelayCommand(Action execute, Func<bool> canExecute)
    {
        ArgumentNullException.ThrowIfNull(execute);
        ArgumentNullException.ThrowIfNull(canExecute);

        this.execute = execute;
        this.canExecute = canExecute;
    }

    public void NotifyCanExecuteChanged()
    {
        CommandManager.InvalidateRequerySuggested();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool CanExecute(object? parameter)
    {
        return this.canExecute?.Invoke() != false;
    }

    public void Execute(object? parameter)
    {
        this.execute();
    }
}