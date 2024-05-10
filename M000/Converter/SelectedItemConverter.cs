using System.Globalization;
using System.Windows.Data;

namespace M000.Converter;

public class SelectedItemConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value is not null;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => true;
}