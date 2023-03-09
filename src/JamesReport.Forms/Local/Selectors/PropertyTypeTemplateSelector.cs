using System.Windows.Controls;
using System.Windows;
using JamesReport.Forms.UI.Units;

namespace JamesReport.Forms.Local.Selectors
{
    public class PropertyTypeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TableTemplate { get; set; }
        public DataTemplate CellFieldTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            // Null value can be passed by IDE designer

            if (item is CellField)
            {
                return CellFieldTemplate;
            }
            else if (item is Table)
            {
                return TableTemplate;
            }
            return TableTemplate;
        }
    }
}
