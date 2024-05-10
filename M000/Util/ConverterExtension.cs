using System.Windows.Data;
using System.Windows.Markup;

namespace M000.Util;

public class ConverterExtension : MarkupExtension
{
	public Type ConverterType { get; set; }

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (ConverterType == null)
			throw new ArgumentNullException();

		if (ConverterType.GetInterface(nameof(IValueConverter)) == null)
			throw new ArgumentException("ConverterType must be of type IValueConverter");

		return Activator.CreateInstance(ConverterType);
	}
}