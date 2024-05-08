using M000;
using System.Windows;

namespace M011;

public partial class MainWindow : Window
{
	public Person person { get; set; } = new Person();

	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		MessageBox.Show(a.PickedColor.ToString());
	}

	private void a_RValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{

	}

	private void Button_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
	{
		Title += "B";
	}

	private void StackPanel_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
	{
		Title += "S";
	}

	private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
	{
		Title += "W";
	}




	private void Button_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
	{
		Title += "B";
	}

	private void StackPanel_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
	{
		Title += "S";
	}

	private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
	{
		Title += "W";
	}
}