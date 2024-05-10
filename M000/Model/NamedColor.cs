using System.Windows.Media;

namespace M000.Model;

public class NamedColor
{
    public Color Color { get; set; }

    public SolidColorBrush Brush { get; set; }

    public string Name { get; set; }

    public NamedColor(Color color, string name)
    {
        Color = color;
        Name = name;
        Brush = new SolidColorBrush(Color);
    }
}