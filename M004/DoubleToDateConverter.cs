using System.Globalization;
using System.Windows.Data;

namespace M004;

/// <summary>
/// Strg + . -> Enter: Methoden generieren
/// </summary>
public class DoubleToDateConverter : IValueConverter
{
	/// <summary>
	/// Quelle -> Ziel
	/// Slider -> DatePicker
	/// value: double, return: DateTime
	/// 
	/// Dieser Code wird zwischen das Binding gehängt
	/// </summary>
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		double d = (double) value;
		DateTime dt = new DateTime().AddDays(d);
		return dt;
	}

	/// <summary>
	/// Ziel -> Quelle
	/// DatePicker -> Slider
	/// value: DateTime, return: double
	/// </summary>
	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		DateTime dt = (DateTime) value;
		double days = (dt - new DateTime()).TotalDays;
		return days;
	}
}