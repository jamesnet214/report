﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Infragistics.Controls.Editors;
using JamesReport.Core;
using JamesReport.Data;
using System.Collections.Generic;

namespace JamesReport.Forms.Local.ViewModels
{
    public partial class ReportContentViewModel : ObservableObject
    {
        [ObservableProperty]
        private DragMoveContent _selectedObject;

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

        [RelayCommand]
        private void SelectItem(DragMoveContent item)
        {
            SelectedObject = item;
        }
    }
}
