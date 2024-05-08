using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M000;

public partial class IntegerUpDown : UserControl
{
	public IntegerUpDown() => InitializeComponent();

	public int Value
	{
		get => (int) GetValue(ValueProperty);
		set => SetValue(ValueProperty, value);
	}

	public static readonly DependencyProperty ValueProperty =
		DependencyProperty.Register
		(
			nameof(Value),
			typeof(int),
			typeof(IntegerUpDown),
			new PropertyMetadata(0)
		);

	private void UpClicked(object sender, RoutedEventArgs e)
	{
		Value++;
	}

	private void DownClicked(object sender, RoutedEventArgs e)
	{
		Value--;
	}
}