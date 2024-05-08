using System.Collections;
using System.Globalization;
using System.Windows.Data;

namespace M013;

public class CollectionAppendConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		IEnumerable objects = value as IEnumerable;
		return string.Join(", ", objects.OfType<string>());
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => null;
}