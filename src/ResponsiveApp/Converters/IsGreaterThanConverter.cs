﻿using System.Globalization;
using System.Windows.Data;

namespace ResponsiveApp.Converters;

public class IsGreaterThanConverter : IValueConverter
{
    public static readonly IValueConverter Instance = new IsGreaterThanConverter();

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        double doubleValue = System.Convert.ToDouble(value);
        double compareToValue = System.Convert.ToDouble(parameter);

        return doubleValue > compareToValue;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}