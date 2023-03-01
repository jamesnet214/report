using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace JamesReport.Forms.UI.Units
{
    public class HorizontalLine : ContentControl
    {
        static HorizontalLine()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HorizontalLine), new FrameworkPropertyMetadata(typeof(HorizontalLine)));
        }
    }
}
