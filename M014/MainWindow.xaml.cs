using System.Windows;
using System.Windows.Input;

namespace M014;

public partial class MainWindow : Window
{
	public CloseCommand Close { get; set; } = new();

	public CustomCommand CustomClose { get; set; } = new CustomCommand
	(
		p =>
		{
			Window w = (Window) p;
			w.Close();
		},
		p => true
	);

	public MainWindow()
	{
		InitializeComponent();
	}
}

/// <summary>
/// Command enthält Execute und CanExecute
/// Execute: Code, welcher beim ausführen des Commands ausgeführt wird
/// CanExecute: Bestimmt ob das Command jetzt ausgeführt werden kann
/// 
/// Später kann das Command als Variable deklariert werden und per Binding an die UI Komponente gebunden werden
/// 
/// Jedes Click-Event benötigt nun ein eigenes Command
/// Jedes mal eine neue Klasse erstellen wird anstrengend -> generisches Command
/// </summary>
public class CloseCommand : ICommand
{
	public event EventHandler? CanExecuteChanged;

	public bool CanExecute(object? parameter)
	{
		return true;
	}

	public void Execute(object? parameter)
	{
		Window w = (Window) parameter;
		w.Close();
	}
}