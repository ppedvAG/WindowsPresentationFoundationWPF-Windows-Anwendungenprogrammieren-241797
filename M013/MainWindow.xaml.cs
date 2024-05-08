using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace M013;

public partial class MainWindow : Window
{
	public ObservableCollection<Person> personen { get; set; } = new();

	public MainWindow()
	{
		InitializeComponent();

		string readJson = File.ReadAllText(@"Personen.json");
		List<Person> p = JsonSerializer.Deserialize<List<Person>>(readJson)!;
		foreach (Person person in p)
		{
			personen.Add(person);
		}
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Button b = sender as Button;
		Person p = b.Tag as Person;
		personen.Remove(p);
	}
}

///////////////////////////////////////////////////////////////////////////////

[DebuggerDisplay("Person - ID: {ID}, Vorname: {Vorname}, Nachname: {Nachname}, GebDat: {Geburtsdatum.ToString(\"yyyy.MM.dd\")}, Alter: {Alter}, " +
	"Jobtitel: {Job.Titel}, Gehalt: {Job.Gehalt}, Einstellungsdatum: {Job.Einstellungsdatum.ToString(\"yyyy.MM.dd\")}")]
public record Person(int ID, string Vorname, string Nachname, DateTime Geburtsdatum, int Alter, Beruf Job, List<string> Hobbies);

public record Beruf(string Titel, int Gehalt, DateTime Einstellungsdatum);

///////////////////////////////////////////////////////////////////////////////