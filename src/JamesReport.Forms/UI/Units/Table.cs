using Jamesnet.Wpf.Controls;
using JamesReport.Core;
using System.Windows;
using System.Windows.Controls;

namespace JamesReport.Forms.UI.Units
{
    public class Table : DragMoveContent
    {
        static Table()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Table), new FrameworkPropertyMetadata(typeof(Table)));
        }
    }
}
