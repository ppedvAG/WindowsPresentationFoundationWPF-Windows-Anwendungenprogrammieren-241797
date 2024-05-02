using System.Collections.ObjectModel;
using System.Windows;

namespace M005;

public partial class MainWindow : Window
{
	//public Person person { get; set; } // = new Person(); // = new Person() { Vorname = "Max", Nachname = "Mustermann", Alter = 33 };

	public BindableProperty<Person> person { get; set; } = new();

	/// <summary>
	/// Funktioniert wie List, aber benachrichtigt die GUI, wenn ein Element hinzugefügt oder entfernt wird
	/// </summary>
	public ObservableCollection<Person> personen { get; set; } = new ObservableCollection<Person>();

	public MainWindow()
	{
		InitializeComponent();

		//Dieser Personen Datensatz soll an die GUI gebunden werden
		person.Value = new Person(); //Die person Variable hat selbst keinen Benachrichtigungsmechanismus -> hier müsste auch INotifyPropertyChanged implementiert werden
		person.Value.Vorname = "Max"; //Hier findet eine Benachrichtigung statt
		person.Value.Nachname = "Mustermann"; //Hier findet eine Benachrichtigung statt
		person.Value.Alter = 33; //Hier findet eine Benachrichtigung statt
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		person.Value.Alter++;
	}

	private void Button_Click_1(object sender, RoutedEventArgs e)
	{
		personen.Add(new Person() { Alter = Random.Shared.Next() });
	}
}