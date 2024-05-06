using System.ComponentModel;

namespace M009;

public class Person : INotifyPropertyChanged, IDataErrorInfo
{
	private string vorname;

	public string Vorname
	{
		get => vorname;
		set
		{
			//if (!value.All(char.IsLetter) || value.Length < 3 || value.Length > 15)
			//	throw new ArgumentException("Die Fehler...");

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

	/// <summary>
	/// Kann ignoriert werden
	/// </summary>
	public string Error => "";

	/// <summary>
	/// Indexer: Gibt die Möglichkeit, Objekte dieser Klasse mit [] anzusprechen
	/// Wenn hier nicht null zurückgegeben wird, handelt es sich um einen Fehler
	/// </summary>
	public string this[string columnName]
	{
		get
		{
			switch (columnName)
			{
				case nameof(Vorname):
					if (!Vorname.All(char.IsLetter) || Vorname.Length < 3 || Vorname.Length > 15)
						return "Fehler bei Vorname"; //Wenn hier nicht null zurückgegeben wird, handelt es sich um einen Fehler
					break;
				case nameof(Nachname):
					break;
				case nameof(Alter):
					break;
			}

			return null; //Erfolg
		}
	}





	//Die GUI hängt dieses Event automatisch an, wir müssen es feuern
	public event PropertyChangedEventHandler? PropertyChanged;

	//Diese Methode muss jetzt bei jedem Property (Vorname, Nachname und Alter) implementiert werden, damit diese Properties benachrichtigen können
	public void Notify(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}