using System.Globalization;
using System.Windows.Data;

namespace M013;

public class DateTimeConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		DateTime dt = (DateTime)value;
		string par = parameter.ToString()!;
		if (string.IsNullOrEmpty(par))
			return dt.ToString("yyyy.MM.dd");
		return dt.ToString(par);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => null;
}