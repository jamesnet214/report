using Jamesnet.Wpf.Global.Location;
using JamesReport.Forms.Local.ViewModels;
using JamesReport.Forms.UI.Views;

namespace JamesReport.Settings
{
    public class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<ReportContent, ReportContentViewModel>();
        }
    }
}
