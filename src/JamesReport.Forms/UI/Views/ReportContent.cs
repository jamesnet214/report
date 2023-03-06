using Jamesnet.Wpf.Controls;
using System.Windows;

namespace JamesReport.Forms.UI.Views
{
    public class ReportContent : JamesContent
    {
        static ReportContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ReportContent), new FrameworkPropertyMetadata(typeof(ReportContent)));
        }
    }
}
