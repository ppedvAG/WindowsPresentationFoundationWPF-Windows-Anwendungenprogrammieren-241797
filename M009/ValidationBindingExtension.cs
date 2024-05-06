using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace M009;

public class ValidationBindingExtension : MarkupExtension
{
	private Binding b { get; set; }

	/// <summary>
	/// Diese Extension möchte ein normales Binding haben
	/// {Binding ElementName=Anzeige, Path=Text}
	/// </summary>
	public ValidationBindingExtension(Binding b, IEnumerable<ValidationRule> rules)
	{
		foreach (ValidationRule rule in rules)
			b.ValidationRules.Add(rule);
		this.b = b;
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return b.ProvideValue(serviceProvider);
	}
}