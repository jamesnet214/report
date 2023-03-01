using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace JamesReport.Forms.UI.Units
{
    public class Table : ContentControl
    {
        static Table()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Table), new FrameworkPropertyMetadata(typeof(Table)));
        }
    }
}
