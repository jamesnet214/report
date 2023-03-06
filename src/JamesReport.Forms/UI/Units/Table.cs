using JamesReport.Core;
using System.Windows;

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
