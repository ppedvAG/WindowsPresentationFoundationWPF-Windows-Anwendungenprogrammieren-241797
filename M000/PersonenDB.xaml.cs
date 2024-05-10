using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace M000;

public partial class PersonenDB : Window
{
	public ObservableCollection<Person> Personen { get; set; } = new();

	public PersonenDB()
	{
		InitializeComponent();

		Personen.Add(new Person() { Vorname = "Max", Nachname = "Mustermann", Geschlecht = Geschlecht.M, Lieblingsfarbe = Colors.Aqua, GebDat = DateTime.Now, Verheiratet = true, AnzKinder = 1 });
		Personen.Add(new Person() { Vorname = "Max", Nachname = "Mustermann", Geschlecht = Geschlecht.M, Lieblingsfarbe = Colors.Orange, GebDat = DateTime.Now, Verheiratet = true, AnzKinder = 1 });
		Personen.Add(new Person() { Vorname = "Max", Nachname = "Mustermann", Geschlecht = Geschlecht.M, Lieblingsfarbe = Colors.LightGreen, GebDat = DateTime.Now, Verheiratet = true, AnzKinder = 1 });
	}

	private void MenuItem_Click(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void NeuePersonClicked(object sender, RoutedEventArgs e)
	{
		Personendialog dialog = new Personendialog();
		bool? result = dialog.ShowDialog();
		if (result == true)
		{
			Personen.Add(dialog.person);
		}
	}

	private void PersonBearbeitenClicked(object sender, RoutedEventArgs e)
	{
		Personendialog dialog = new Personendialog();
		Person current = (Person) DG.SelectedItem;
		dialog.person = current.Clone();
		bool? result = dialog.ShowDialog();
		if (result == true)
		{
			Personen.Remove(current);
			Personen.Add(dialog.person);
		}
	}

	private void PersonEntfernenClicked(object sender, RoutedEventArgs e)
	{
		if (MessageBox.Show("Möchtest du die Person wirklich löschen?", "Person löschen", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
		{
			Personen.Remove((Person) DG.SelectedItem);
		}
	}

	private void DG_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
	{
		PersonBearbeitenClicked(sender, null);
	}
}