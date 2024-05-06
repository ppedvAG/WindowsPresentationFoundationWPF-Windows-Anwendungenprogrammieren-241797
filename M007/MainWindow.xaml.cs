using System.Collections.ObjectModel;
using System.Windows;

namespace M007;

public partial class MainWindow : Window
{
	public ObservableCollection<Person> personen { get; set; } = new();

	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		personen.Add(new Person() { Vorname = "Max", Nachname = "Mustermann", Alter = Random.Shared.Next() });
	}
}