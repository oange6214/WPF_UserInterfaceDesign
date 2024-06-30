using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PageNavigationApp.Utilities.Mvvm.Input;

public sealed class RelayCommand<T> : IRelayCommand<T>
{
    private readonly Action<T?> execute;
    private readonly Predicate<T?>? canExecute;

    public event EventHandler? CanExecuteChanged;

    public RelayCommand(Action<T?> execute)
    {
        ArgumentNullException.ThrowIfNull(execute);

        this.execute = execute;
    }

    public RelayCommand(Action<T?> execute, Predicate<T?> canExecute)
    {
        ArgumentNullException.ThrowIfNull(execute);
        ArgumentNullException.ThrowIfNull(canExecute);

        this.execute = execute;
        this.canExecute = canExecute;
    }

    public void NotifyCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool CanExecute(T? parameter)
    {
        return this.canExecute?.Invoke(parameter) != false;
    }

    public bool CanExecute(object? parameter)
    {
        // Special case a null value for a value type argument type.
        // This ensures that no exceptions are thrown during initialization.
        if (parameter is null && default(T) is not null)
        {
            return false;
        }

        if (!TryGetCommandArgument(parameter, out T? result))
        {
            ThrowArgumentExceptionForInvalidCommandArgument(parameter);
        }

        return CanExecute(result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Execute(T? parameter)
    {
        this.execute(parameter);
    }

    public void Execute(object? parameter)
    {
        if (!TryGetCommandArgument(parameter, out T? result))
        {
            ThrowArgumentExceptionForInvalidCommandArgument(parameter);
        }

        Execute(result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static bool TryGetCommandArgument(object? parameter, out T? result)
    {
        // If the argument is null and the default value of T is also null, then the
        // argument is valid. T might be a reference type or a nullable value type.
        if (parameter is null && default(T) is null)
        {
            result = default;

            return true;
        }

        // Check if the argument is a T value, so either an instance of a type or a derived
        // type of T is a reference type, an interface implementation if T is an interface,
        // or a boxed value type in case T was a value type.
        if (parameter is T argument)
        {
            result = argument;

            return true;
        }

        result = default;

        return false;
    }

    [DoesNotReturn]
    internal static void ThrowArgumentExceptionForInvalidCommandArgument(object? parameter)
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        static Exception GetException(object? parameter)
        {
            if (parameter is null)
            {
                return new ArgumentException($"Parameter \"{nameof(parameter)}\" (object) must not be null, as the command type requires an argument of type {typeof(T)}.", nameof(parameter));
            }

            return new ArgumentException($"Parameter \"{nameof(parameter)}\" (object) cannot be of type {parameter.GetType()}, as the command type requires an argument of type {typeof(T)}.", nameof(parameter));
        }

        throw GetException(parameter);
    }
}