using System.Windows.Markup;

namespace M008;

public class EnumExtension : MarkupExtension
{
	private Type EnumType { get; set; }

	public EnumExtension(Type t)
	{
		if (t == null || !t.IsEnum)
			throw new ArgumentException("EnumType muss ein Enum Typ sein");

		EnumType = t;
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return Enum.GetValues(EnumType);
	}
}