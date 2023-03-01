using Jamesnet.Wpf.Controls;
using JamesReport.Core;
using System.Windows;
using System.Windows.Controls;

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
