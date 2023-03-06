using JamesReport.Core;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace JamesReport.Settings
{
    internal class DirectModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            IRegionManager region = containerProvider.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("MainRegion", ContentName.ReportContent);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
