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
    internal class Starter
    {
        [STAThread]
        static void Main(string[] args)
        {
            App app = new();
            app.Run();
        }
    }
}
