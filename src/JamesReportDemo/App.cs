using JamesReport.Forms.Local.ViewModels;
using JamesReport.Forms.UI.Views;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JamesReportDemo
{
    internal class App : PrismApplication
    {
        public App()
        {
            ViewModelLocationProvider.Register<ReportContent, ReportContentViewModel>();
            ViewModelLocationProvider.Register<MainWindow1, MainViewModel>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        
        }

        protected override Window CreateShell()
        {
            return new MainWindow1();
        }

        
    }
}
