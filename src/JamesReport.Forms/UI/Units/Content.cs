using JamesReport.Core;
using System.Windows;

namespace JamesReport.Forms.UI.Units
{
    public class Text : DragMoveContent
    {
        static Text()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Text), new FrameworkPropertyMetadata(typeof(Text)));
        }
    }
}
