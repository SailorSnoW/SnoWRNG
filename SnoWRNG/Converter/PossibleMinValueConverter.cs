using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace SnoWRNG.Converter;

public class PossibleMinValueConverter: IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return (int?)value - 1;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return (int?)value + 1;
    }
}