using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Windows.Media;

namespace M000.Model;

public class Person : INotifyPropertyChanged
{
    private string vorname = string.Empty;

    public string Vorname
    {
        get => vorname;
        set
        {
            vorname = value;
            Notify();
        }
    }

    private string nachname = string.Empty;

    public string Nachname
    {
        get => nachname;
        set
        {
            nachname = value;
            Notify();
        }
    }

    private DateTime gebDat = DateTime.Now;

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

    private Color lieblingsfarbe = new Color();

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

    private int anzKinder;

    public int AnzKinder
    {
        get => anzKinder;
        set
        {
            anzKinder = value;
            Notify();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void Notify([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    public Person Clone()
    {
        return (Person)MemberwiseClone();
    }
}