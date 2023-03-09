using System.Windows;
using System.Windows.Controls;

namespace JamesReport.Forms.UI.Units
{
    public class PropertyGrid : ContentControl
    {
        static PropertyGrid()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PropertyGrid), new FrameworkPropertyMetadata(typeof(PropertyGrid)));
        }
    }
}
