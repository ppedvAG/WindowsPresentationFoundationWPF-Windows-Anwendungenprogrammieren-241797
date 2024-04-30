using System.Globalization;
using System.Windows.Data;

namespace M004;

public class ThreeDoubleToDateConverter : IMultiValueConverter
{
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		double[] sliderValues = values.OfType<double>().ToArray();

		//double[] sliderValues = new double[values.Length];
		//for (int i = 0; i < values.Length; i++)
		//	sliderValues[i] = (double) values[i];

		//2 -> 1 -> 0: values hat die Reihenfolge Tag, Monat, Jahr - DateTime hat die Reihenfolge Jahr, Monat, Tag
		DateTime dt = new DateTime((int) sliderValues[2], (int) sliderValues[1], (int) sliderValues[0]);
		return dt;
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		DateTime dt = (DateTime) value;
		return [(double) dt.Day, (double) dt.Month, (double) dt.Year];
	}
}