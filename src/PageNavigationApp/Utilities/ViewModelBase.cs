using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace PageNavigationApp.Utilities;

public class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        ArgumentNullException.ThrowIfNull(e);

        PropertyChanged?.Invoke(this, e);
    }

    public void OnPropertyChanged([CallerMemberName] string propoName = null)
    {
        OnPropertyChanged(new PropertyChangedEventArgs(propoName));
    }

    protected virtual bool SetProperty<T>([NotNullIfNotNull(nameof(newValue))] ref T field, T newValue, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, newValue))
        {
            return false;
        }

        field = newValue;

        OnPropertyChanged(propertyName);

        return true;
    }

    protected bool SetProperty<T>(T oldValue, T newValue, Action<T> callback, [CallerMemberName] string? propertyName = null)
    {
        ArgumentNullException.ThrowIfNull(callback);

        if (EqualityComparer<T>.Default.Equals(oldValue, newValue))
        {
            return false;
        }

        callback(newValue);

        OnPropertyChanged(propertyName);

        return true;
    }
}