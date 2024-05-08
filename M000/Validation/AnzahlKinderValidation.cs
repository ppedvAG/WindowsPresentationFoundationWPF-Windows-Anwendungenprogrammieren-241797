using System.Globalization;
using System.Windows.Controls;

namespace M000.Validation;

public class AnzahlKinderValidation : ValidationRule
{
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		int zahl = (int)value;
		if (zahl >= 0)
			return ValidationResult.ValidResult;
		return new ValidationResult(false, "Wert darf nicht kleiner als 0 sein!");
	}
}