using JamesReport.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace JamesReport.Models
{
    public class ReportObjectModel
    {
        public Type Type { get; set; }
        public object Content{ get; set; }
        public FontWeight FontWeight { get; set; }
        public double FontSize { get; set; } = 12;
        public string Rows { get; set; }
        public string Columns { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Stretch Stretch { get; set; }
        public Thickness BorderThickness { get; set; }
        public Brush Background { get; set; }
        public Brush BorderBrush { get; set; }
        public double Top { get; set; } = 0;
        public double Left { get; set; } = 0;
        public List<ReportObjectModel> CellFields { get; set; }
        public CellType CellType { get; set; }
        public int RowSpan { get; set; }
        public int ColumnSpan { get; set; }
        public string Base64 { get; set; }
    }
}
