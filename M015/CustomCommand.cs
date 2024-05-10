using System.Windows.Input;

namespace M015;

/// <summary>
/// Action, Func: Zwei Datentypen, welche jeweils einen Methodenzeiger halten können
/// Diese beiden Datentypen können beim Konstruktor verwendet werden, um vom Benutzer beliebige Methoden zu verlangen 
/// 
/// Action: Methode ohne Rückgabewert
/// Func: Methode mit Rückgabewert
/// </summary>
public class CustomCommand : ICommand
{
	public Action<object> executeAction;

	public Func<object, bool> canExecuteFunc = p => true;

	/// <summary>
	/// Action<object>: Methodenzeiger, welcher keinen Rückgabewert hat, und einen Parameter vom Typ object hat
	/// Func<object, bool>: Methodenzeiger, welcher einen bool zurückgibt, und einen Parameter vom Typ object hat
	/// 
	/// Diese Methodenzeiger können in weiterer Folge bei den Command Methoden ausgeführt werden
	/// </summary>
	public CustomCommand(Action<object> execute, Func<object, bool> canExecute)
	{
		executeAction = execute;
		if (canExecuteFunc != null)
			canExecuteFunc = canExecute;
	}

	public CustomCommand() { }

	public void Execute(object? parameter) => executeAction(parameter);

	public bool CanExecute(object? parameter) => canExecuteFunc(parameter);

	public event EventHandler? CanExecuteChanged;
}