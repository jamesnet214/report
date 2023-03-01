using System.Windows;
using System.Windows.Controls;

namespace JamesReport.Forms.UI.Units
{
    public class ItemsListItem : ListBox
    {
        static ItemsListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemsListItem), new FrameworkPropertyMetadata(typeof(ItemsListItem)));
        }
    }
}
