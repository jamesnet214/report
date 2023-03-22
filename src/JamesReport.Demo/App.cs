using Jamesnet.Wpf.Controls;
using JamesReport.Core.Events;
using JamesReport.Forms.UI.Views;
using JamesReport.SampleData;
using Prism.Ioc;
using System.Windows;

namespace JamesReport
{
    public class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new ReportWindow();
        }
    }
}
