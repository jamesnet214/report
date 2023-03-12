using Jamesnet.Wpf.Controls;
using JamesReport.Forms.Local.ViewModels;
using JamesReport.Forms.UI.Views;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace JamesReportDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ViewModelLocationProvider.Register<ReportContent, ReportContentViewModel>();
        }
    }
}
