using M000.Model;
using M000.Util;
using System.Windows;

namespace M000.ViewModel;

public class PersonendialogViewModel : ViewModelBase
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

	public CustomCommand OKCommand { get; set; } = new CustomCommand();

	public CustomCommand AbbrechenCommand { get; set; } = new CustomCommand();

	public PersonendialogViewModel()
	{
		OKCommand.executeAction = OK;
		AbbrechenCommand.executeAction = Abbrechen;
	}

	private void OK(object p)
	{
		MessageBoxResult result = MessageBox.Show($"{person.Vorname}\n{person.Nachname}\n...", "Derzeitige Person", MessageBoxButton.YesNo, MessageBoxImage.Information);
		if (result == MessageBoxResult.Yes)
		{
			Window w = (Window) p;
			w.DialogResult = true;
			w.Close();
		}
	}

	private void Abbrechen(object p)
	{
		//person aus DB laden
		person.Vorname = "Max";
		person.Nachname = "Mustermann";
		person.GebDat = new DateTime(2000, 01, 01);
		person.Verheiratet = true;
		person.Geschlecht = Geschlecht.D;

		Window w = (Window) p;
		w.DialogResult = false;
	}
}