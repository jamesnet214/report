using JamesReport.Core;
using System.Windows;

namespace JamesReport.Forms.UI.Units
{
    public class Picture : DragMoveContent
    {
        static Picture()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Picture), new FrameworkPropertyMetadata(typeof(Picture)));
        }
    }
}
