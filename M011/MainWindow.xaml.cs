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
}