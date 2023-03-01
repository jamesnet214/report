using Jamesnet.Wpf.Global.Location;
using JamesReport.Forms.Local.ViewModels;
using JamesReport.Forms.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
