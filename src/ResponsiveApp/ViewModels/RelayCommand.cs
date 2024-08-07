﻿using System.Windows.Input;

namespace ResponsiveApp.ViewModels;

public class RelayCommand : ICommand
{
    private Func<object, bool> canExecute;
    private Action<object> execute;

    public RelayCommand(Action<object> execute)
    {
        this.execute = execute;
        canExecute = null;
    }

    public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
    {
        this.execute = execute;
        this.canExecute = canExecute;
    }

    public event EventHandler CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    public bool CanExecute(object parameter)
    {
        return canExecute == null || CanExecute(parameter);
    }

    public void Execute(object parameter)
    {
        execute(parameter);
    }
}