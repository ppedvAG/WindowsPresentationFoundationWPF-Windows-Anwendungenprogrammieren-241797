using System.Reflection;
using System.Windows.Markup;
using System.Windows.Media;
using M000.Model;

namespace M000.Util;

public class ColorsExtension : MarkupExtension
{
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        List<NamedColor> colors = new List<NamedColor>();
        foreach (PropertyInfo pi in typeof(Colors).GetProperties())
        {
            colors.Add(new NamedColor((Color)pi.GetValue(null), pi.Name)); //GetValue: entnimmt aus dem Property (pi) den Wert dahinter
        }
        return colors;
    }
}