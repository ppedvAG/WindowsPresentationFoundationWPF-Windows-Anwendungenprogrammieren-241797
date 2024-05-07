using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace M011;

public partial class ColorPicker : UserControl
{
	public ColorPicker()
	{
		InitializeComponent();
	}

	/// <summary>
	/// propdp + Tab + Tab
	/// </summary>
	public Color PickedColor
	{
		get => (Color) GetValue(PickedColorProperty);
		set => SetValue(PickedColorProperty, value);
	}

	public static readonly DependencyProperty PickedColorProperty =
		DependencyProperty.Register
		(
			nameof(PickedColor), //Name des Properties
			typeof(Color), //Typ des Properties
			typeof(ColorPicker), //Typ der Klasse die das Property enthält
			new PropertyMetadata(new Color()) //Standardwert setzen
		);



	public byte R
	{
		get => (byte) GetValue(RProperty);
		set => SetValue(RProperty, value);
	}

	public static readonly DependencyProperty RProperty =
		DependencyProperty.Register
		(
			nameof(R),
			typeof(byte),
			typeof(ColorPicker),
			new PropertyMetadata((byte) 0, SliderValuesChanged)
		);



	public byte G
	{
		get => (byte) GetValue(GProperty);
		set => SetValue(GProperty, value);
	}

	public static readonly DependencyProperty GProperty =
		DependencyProperty.Register
		(
			nameof(G),
			typeof(byte),
			typeof(ColorPicker),
			new PropertyMetadata((byte) 0, SliderValuesChanged)
		);



	public byte B
	{
		get => (byte) GetValue(BProperty);
		set => SetValue(BProperty, value);
	}

	public static readonly DependencyProperty BProperty =
		DependencyProperty.Register
		(
			nameof(B),
			typeof(byte),
			typeof(ColorPicker),
			new PropertyMetadata((byte) 0, SliderValuesChanged)
		);




	public byte A
	{
		get => (byte) GetValue(AProperty);
		set => SetValue(AProperty, value);
	}

	public static readonly DependencyProperty AProperty =
		DependencyProperty.Register
		(
			nameof(A),
			typeof(byte),
			typeof(ColorPicker),
			new PropertyMetadata((byte) 0, SliderValuesChanged)
		);


	public static void SliderValuesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		Color c = Color.FromArgb((byte) d.GetValue(AProperty), (byte) d.GetValue(RProperty), (byte) d.GetValue(GProperty), (byte) d.GetValue(BProperty));
		d.SetValue(PickedColorProperty, c);
	}
}