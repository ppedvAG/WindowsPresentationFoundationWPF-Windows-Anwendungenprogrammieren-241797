using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace M015.Model;

public class Person : INotifyPropertyChanged
{
	private Color lieblingsfarbe = Color.FromArgb(255, 255, 255, 255);

	public Color Lieblingsfarbe
	{
		get => lieblingsfarbe;
		set
		{
			lieblingsfarbe = value;
			Notify();
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}