using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Mvvm;
using JamesReport.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesReport.Forms.Local.ViewModels
{
    public partial class ReportContentViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<ToolItem> _tools;

        public ReportContentViewModel()
        {
            Tools = GetTools();
        }

        private List<ToolItem> GetTools()
        {
            List<ToolItem> source = new();
            source.Add(new ToolItem("Title"));
            source.Add(new ToolItem("Table"));
            source.Add(new ToolItem("Horizontal Line"));
            source.Add(new ToolItem("Image"));
            return source;
        }
    }
}
