using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Global.Evemt;
using Jamesnet.Wpf.Mvvm;
using JamesReport.Core;
using JamesReport.Core.Events;
using JamesReport.Models;
using JamesReport.Forms.UI.Units;
using JamesReport.Forms.UI.Views;
using Newtonsoft.Json;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Documents;
using System.Buffers.Text;
using JamesReport.SampleData;

namespace JamesReport.Forms.Local.ViewModels
{
    public partial class ReportContentViewModel : ObservableBase, IViewLoadable
    {
        [ObservableProperty]
        private ReportObject _selectedObject;

        [ObservableProperty]
        private List<ToolItem> _tools;

        [ObservableProperty]
        private ObservableCollection<ReportObject> _reportSource;
        private IEventAggregator _eh;

        public ReportContentViewModel(IEventAggregator eh)
        {
            _eh = eh;
            _eh.GetEvent<ReportLoadEvent>().Subscribe(ReportLoad);
            Tools = GetTools();
        }

        public void OnLoaded(IViewable view)
        {
            ReportLoad(EncryptData.Base64);
        }

        private void ReportLoad(string base64)
        {
            ReportSource = GetReportSource(base64);
        }

        private ObservableCollection<ReportObject> GetReportSource(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            string json = Encoding.UTF8.GetString(bytes);

            var obj = JsonConvert.DeserializeObject<ReportModel>(json);

            List<ReportObject> list = new();
            foreach (var data in obj.Objects)
            {
                ReportObject item = null;
                switch (data.Type.Name)
                {
                    case "Header": item = new Header().SetProperties(data); break;
                    case "HorizontalLine": item = new HorizontalLine().SetProperties(data); break;
                    case "Text": item = new Text().SetProperties(data); break;
                    case "Table": item = new JamesReport.Forms.UI.Units.Table().SetProperties(data); break;
                    case "Picture": item = new Picture().SetProperties(data); break;
                }
                list.Add(item);
            }

            return new ObservableCollection<ReportObject>(list);
        }

        [RelayCommand]
        private void Save()
        {
            ReportModel m = new();
            m.Objects = new();
            foreach (ReportObject data in ReportSource)
            {
                var item = data.GetProperties();
                m.Objects.Add(item);
            }

            string json = JsonConvert.SerializeObject(m);
            byte[] bytes = Encoding.UTF8.GetBytes(json);
            string base64 = Convert.ToBase64String(bytes);
            Clipboard.SetText(base64);

            _eh.GetEvent<ReportSaveEvent>().Publish(base64);
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

        [RelayCommand]
        private void SelectItem(ReportObject item)
        {
            SelectedObject = item;
        }
    }
}
