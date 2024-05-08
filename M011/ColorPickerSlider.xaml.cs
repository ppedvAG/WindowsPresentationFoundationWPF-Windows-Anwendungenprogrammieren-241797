using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M011;

public partial class ColorPickerSlider : UserControl
{
	public ColorPickerSlider() => InitializeComponent();


	public string ColorName
	{
		get => (string) GetValue(ColorNameProperty);
		set => SetValue(ColorNameProperty, value);
	}

	public static readonly DependencyProperty ColorNameProperty =
		DependencyProperty.Register
		(
			nameof(ColorName),
			typeof(string),
			typeof(ColorPickerSlider),
			new PropertyMetadata("")
		);




	public Color SliderColor
	{
		get => (Color) GetValue(SliderColorProperty);
		set => SetValue(SliderColorProperty, value);
	}

	public static readonly DependencyProperty SliderColorProperty =
		DependencyProperty.Register
		(
			nameof(SliderColor),
			typeof(Color),
			typeof(ColorPickerSlider),
			new PropertyMetadata(new Color())
		);



	public int SliderValue
	{
		get => (int) GetValue(SliderValueProperty);
		set => SetValue(SliderValueProperty, value);
	}

	public static readonly DependencyProperty SliderValueProperty =
		DependencyProperty.Register
		(
			nameof(SliderValue),
			typeof(int),
			typeof(ColorPickerSlider),
			new PropertyMetadata(0)
		);


}