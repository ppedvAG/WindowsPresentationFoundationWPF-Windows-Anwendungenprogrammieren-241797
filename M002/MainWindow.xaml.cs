using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace M002;

public partial class MainWindow : Window
{
	private string TextBuffer;

	public MainWindow()
	{
		InitializeComponent();

		CB.ItemsSource = new string[] { "Test1", "Test2", "Test3" };
		LB.ItemsSource = new string[] { "Test1", "Test2", "Test3" };
	}

	/// <summary>
	/// Strg R + R: Methode umbenennen
	/// Wenn hier die Methode umbenannt wird, wird sie im XAML auch umbenannt
	/// </summary>
	private void TestClicked(object sender, RoutedEventArgs e)
	{
		TB.Text = "Test";
		TextBuffer = TB.Text;

		PB.Value++;
	}

	private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
	{
		TextBuffer = TB.Text;
		TB.Text = "Button hovered";
	}

	private void Button_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
	{
		TB.Text = TextBuffer;
	}

	private void SubmitClicked(object sender, RoutedEventArgs e)
	{
		TB.Text = UserInput.Text;
	}

	private void UserInput_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Enter)
		{
			TB.Text = UserInput.Text;
		}
	}

	private void CB_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		TB.Text = CB.SelectedItem.ToString();
	}

	private void LB_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		TB.Text = string.Join(',', LB.SelectedItems.OfType<string>());
	}

	private void CheckBox_Checked(object sender, RoutedEventArgs e)
	{
		if (IsInitialized)
			TB.Text = "CheckBox checked";
	}

	private void TestSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		TB.FontSize = TestSlider.Value;
		TB.Text = TestSlider.Value.ToString(); //Slider Value ist immer eine Kommazahl -> TickFrequency, IsSnapToTickEnabled
	}

	private void MIClicked(object sender, RoutedEventArgs e)
	{

	}
}