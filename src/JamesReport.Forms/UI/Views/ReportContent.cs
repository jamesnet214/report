using Jamesnet.Wpf.Controls;
using JamesReport.Forms.UI.Units;
using System.Windows;
using System.Windows.Input;

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
