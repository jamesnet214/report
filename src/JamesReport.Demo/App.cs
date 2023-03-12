using Jamesnet.Wpf.Controls;
using JamesReport.Forms.UI.Views;
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
