using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace JamesReport.Forms.UI.Units
{
    public class ItemsList : ListBox
    {
        static ItemsList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemsList), new FrameworkPropertyMetadata(typeof(ItemsList)));
        }
    }
}
