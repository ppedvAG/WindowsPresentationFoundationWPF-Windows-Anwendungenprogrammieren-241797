using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace M000;

public class FourValueToBrushConverter : IMultiValueConverter
{
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		byte[] sliderValues = values
			.OfType<double>()
			.Select(e => (byte) e)
			.ToArray();

		Color c = Color.FromArgb(sliderValues[3], sliderValues[0], sliderValues[1], sliderValues[2]);
		SolidColorBrush brush = new SolidColorBrush(c);
		return brush;
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => null;
}