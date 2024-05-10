using System.Windows;
using System.Collections.ObjectModel;
using M015.Model;

namespace M015.ViewModel;

public class MainWindowViewModel : ViewModelBase
{
	public CustomCommand TestCommand { get; set; } = new CustomCommand();

	public ObservableCollection<Person> personen { get; set; } = new();

	public MainWindowViewModel()
	{
		TestCommand.executeAction = Test;

		personen.Add(new Person());
		personen.Add(new Person());
		personen.Add(new Person());
	}

	public void Test(object p)
	{
		MessageBox.Show("Hallo");
	}
}