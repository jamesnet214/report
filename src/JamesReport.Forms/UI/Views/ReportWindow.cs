using Jamesnet.Wpf.Controls;
using System.Windows;

namespace JamesReport.Forms.UI.Views
{
    public class ReportWindow : JamesWindow
    {
        static ReportWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ReportWindow), new FrameworkPropertyMetadata(typeof(ReportWindow)));
        }
    }
}
