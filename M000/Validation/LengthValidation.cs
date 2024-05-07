using System.Globalization;
using System.Windows.Controls;

namespace M000.Validation;

public class LengthValidation : ValidationRule
{
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		string s = value as string;
		if (s.Length >= 3 && s.Length <= 15)
		{
			return ValidationResult.ValidResult;
		}
		return new ValidationResult(false, "Eingabe muss zwischen 3 und 15 Zeichen haben!");
	}
}