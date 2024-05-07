using System.Globalization;
using System.Windows.Controls;
using System.Windows.Media;

namespace M000.Validation;

public class ColorValidation : ValidationRule
{
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		Color c = (Color)value;
		if (c != new Color())
		{
			return ValidationResult.ValidResult;
		}
		return new ValidationResult(false, "Wähle eine Farbe aus");
	}
}