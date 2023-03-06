using JamesReport.Core;
using System.Windows;

namespace JamesReport.Forms.UI.Units
{
    public class HorizontalLine : DragMoveContent
    {
        static HorizontalLine()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HorizontalLine), new FrameworkPropertyMetadata(typeof(HorizontalLine)));
        }
    }
}
