using Jamesnet.Wpf.Controls;
using JamesReport.Core;
using System.Windows;
using System.Windows.Controls;

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
