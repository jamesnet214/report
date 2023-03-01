using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace JamesReport.Forms.UI.Units
{
    public class Header : ContentControl
    {
        static Header()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Header), new FrameworkPropertyMetadata(typeof(Header)));
        }
    }
}
