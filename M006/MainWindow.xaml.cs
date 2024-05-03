using System.Windows;
using System.Windows.Media;

namespace M006;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
	}

	private void HintergrundAnpassen(object sender, RoutedEventArgs e)
	{
		Resources["DefaultBackground"] = new SolidColorBrush(Colors.Orange);
	}

	private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		Resources["GlobalFontSize"] = e.NewValue;
	}
}