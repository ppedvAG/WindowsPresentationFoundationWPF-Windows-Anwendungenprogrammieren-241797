﻿using System.Globalization;
using System.Windows.Controls;

namespace M000.Validation;

public class DateValidation : ValidationRule
{
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		DateTime dt = (DateTime) value;
		if (dt.Year >= 1900 && dt <= DateTime.Now)
		{
			return ValidationResult.ValidResult;
		}
		return new ValidationResult(false, "Das Geburtsdatum darf nicht vor 1900 sein oder in der Zukunft liegen!");
	}
}