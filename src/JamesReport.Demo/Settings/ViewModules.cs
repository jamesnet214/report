﻿using Jamesnet.Wpf.Controls;
using JamesReport.Core;
using JamesReport.Forms.UI.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace JamesReport.Settings
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, ReportContent>(ContentName.ReportContent);
        }
    }
}
