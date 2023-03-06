using JamesReport.Core;
using System.Windows;

namespace JamesReport.Forms.UI.Units
{
    public class Header : DragMoveContent
    {
        static Header()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Header), new FrameworkPropertyMetadata(typeof(Header)));
        }
    }
}
