using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace M000;

public class Person : INotifyPropertyChanged
{
	private string vorname;

	public string Vorname
	{
		get => vorname;
		set
		{
			vorname = value;
			Notify();
		}
	}

	private string nachname;

	public string Nachname
	{
		get => nachname;
		set
		{
			nachname = value;
			Notify();
		}
	}

	private DateTime gebDat;

	public DateTime GebDat
	{
		get => gebDat;
		set
		{
			gebDat = value;
			Notify();
		}
	}

	private bool verheiratet;

	public bool Verheiratet
	{
		get => verheiratet;
		set
		{
			verheiratet = value;
			Notify();
		}
	}

	private Color lieblingsfarbe;

	public Color Lieblingsfarbe
	{
		get => lieblingsfarbe;
		set
		{
			lieblingsfarbe = value;
			Notify();
		}
	}

	private Geschlecht geschlecht;

	public Geschlecht Geschlecht
	{
		get => geschlecht;
		set
		{
			geschlecht = value;
			Notify();
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}