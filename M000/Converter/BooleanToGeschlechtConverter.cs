using System.Globalization;
using System.Windows.Data;
using M000.Model;

namespace M000.Converter;

public class BooleanToGeschlechtConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (Geschlecht)parameter == (Geschlecht)value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (bool)value ? (Geschlecht)parameter : Binding.DoNothing;
    }
}