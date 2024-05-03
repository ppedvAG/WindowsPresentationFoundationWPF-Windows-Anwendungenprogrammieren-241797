using System.Windows;

namespace M000;

public partial class MainWindow : Window
{
	public Person person { get; set; } = new Person();

	public MainWindow()
	{
		InitializeComponent();
	}

	private void OKClicked(object sender, RoutedEventArgs e)
	{
		MessageBox.Show($"{person.Vorname}\n{person.Nachname}\n...", "Derzeitige Person", MessageBoxButton.YesNo, MessageBoxImage.Information);
	}

	private void AbbrechenClicked(object sender, RoutedEventArgs e)
	{
		//person aus DB laden
		person.Vorname = "Max";
		person.Nachname = "Mustermann";
		person.GebDat = new DateTime(2000, 01, 01);
		person.Verheiratet = true;
		person.Geschlecht = Geschlecht.D;
	}
}