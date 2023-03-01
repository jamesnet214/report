using Jamesnet.Wpf.Controls;
using JamesReport.Core;
using System.Windows;
using System.Windows.Controls;

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
