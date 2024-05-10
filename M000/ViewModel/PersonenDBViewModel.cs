using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;
using M000.Model;
using M000.Util;
using M000.View;

namespace M000.ViewModel;

public class PersonenDBViewModel : ViewModelBase
{
	public ObservableCollection<Person> Personen { get; set; } = new();

	public CustomCommand BeendenCommand { get; set; } = new();

	public CustomCommand NeuePersonCommand { get; set; } = new();

	public CustomCommand PersonBearbeitenCommand { get; set; } = new();

	public CustomCommand PersonEntfernenCommand { get; set; } = new();

    public PersonenDBViewModel()
    {
		Personen.Add(new Person() { Vorname = "Max", Nachname = "Mustermann", Geschlecht = Geschlecht.M, Lieblingsfarbe = Colors.Aqua, GebDat = DateTime.Now, Verheiratet = true, AnzKinder = 1 });
		Personen.Add(new Person() { Vorname = "Max", Nachname = "Mustermann", Geschlecht = Geschlecht.M, Lieblingsfarbe = Colors.Orange, GebDat = DateTime.Now, Verheiratet = true, AnzKinder = 1 });
		Personen.Add(new Person() { Vorname = "Max", Nachname = "Mustermann", Geschlecht = Geschlecht.M, Lieblingsfarbe = Colors.LightGreen, GebDat = DateTime.Now, Verheiratet = true, AnzKinder = 1 });

		BeendenCommand.executeAction = Beenden;
		NeuePersonCommand.executeAction = NeuePerson;
		PersonBearbeitenCommand.executeAction = PersonBearbeiten;
		PersonEntfernenCommand.executeAction = PersonEntfernen;
	}

	public void Beenden(object p)
	{
		Window w = (Window) p;
		w.Close();
	}

	public void NeuePerson(object p)
	{
		Personendialog dialog = new Personendialog();
		PersonendialogViewModel vm = dialog.DataContext as PersonendialogViewModel;
		bool? result = dialog.ShowDialog();
		if (result == true)
		{
			Personen.Add(vm.person);
		}
	}

	public void PersonBearbeiten(object p)
	{
		Personendialog dialog = new Personendialog();
		PersonendialogViewModel vm = dialog.DataContext as PersonendialogViewModel;
		Person current = (Person) p;
		vm.person = current.Clone();
		bool? result = dialog.ShowDialog();
		if (result == true)
		{
			Personen.Remove(current);
			Personen.Add(vm.person);
		}
	}

	public void PersonEntfernen(object p)
	{
		if (MessageBox.Show("Möchtest du die Person wirklich löschen?", "Person löschen", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
		{
			Personen.Remove((Person) p);
		}
	}
}