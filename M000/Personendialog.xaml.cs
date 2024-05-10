using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace M000;

public partial class Personendialog : Window, INotifyPropertyChanged
{
	private Person _person = new Person();

	public Person person
	{
		get => _person;
		set
		{
			_person = value;
			Notify();
		}
	}

	public Personendialog()
	{
		InitializeComponent();
	}

	private void OKClicked(object sender, RoutedEventArgs e)
	{
		MessageBoxResult result = MessageBox.Show($"{person.Vorname}\n{person.Nachname}\n...", "Derzeitige Person", MessageBoxButton.YesNo, MessageBoxImage.Information);
		if (result == MessageBoxResult.Yes)
		{
			DialogResult = true;
			Close();
		}
	}

	private void AbbrechenClicked(object sender, RoutedEventArgs e)
	{
		//person aus DB laden
		person.Vorname = "Max";
		person.Nachname = "Mustermann";
		person.GebDat = new DateTime(2000, 01, 01);
		person.Verheiratet = true;
		person.Geschlecht = Geschlecht.D;

		DialogResult = false;
	}


	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}