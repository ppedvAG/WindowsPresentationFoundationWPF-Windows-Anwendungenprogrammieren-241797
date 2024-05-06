using System.ComponentModel;

namespace M007;

public class Person : INotifyPropertyChanged
{
	private string vorname;

	public string Vorname
	{
		get => vorname;
		set
		{
			vorname = value;
			Notify(nameof(Vorname));
			//Notify("Vorname");
		}
	}

	private string nachname;

	public string Nachname
	{
		get => nachname;
		set
		{
			nachname = value;
			Notify(nameof(Nachname));
		}
	}

	private int alter;

	public int Alter
	{
		get => alter;
		set
		{
			alter = value;
			Notify(nameof(Alter));
		}
	}

	//Die GUI hängt dieses Event automatisch an, wir müssen es feuern
	public event PropertyChangedEventHandler? PropertyChanged;

	//Diese Methode muss jetzt bei jedem Property (Vorname, Nachname und Alter) implementiert werden, damit diese Properties benachrichtigen können
	public void Notify(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}