using System.Collections.ObjectModel;
using System.Windows;

namespace M012;

public partial class MainWindow : Window
{
	public ObservableCollection<string> Data { get; set; } = new ObservableCollection<string>();

	public MainWindow()
	{
		InitializeComponent();
		Data.Add("Test");
		Data.Add("Test1");
		Data.Add("Test2");
	}
}