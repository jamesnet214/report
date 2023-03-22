using JamesReport.Core;
using JamesReport.Models;
using System.Windows;
using System.Windows.Controls;

namespace JamesReport.Forms.UI.Units
{
    public class CellField : CellFieldBase
    {
        public static readonly DependencyProperty TypeProperty = DependencyProperty.Register("Type", typeof(CellType), typeof(CellField), new PropertyMetadata(CellType.Label));
        public static readonly DependencyProperty ColumnSpanProperty = DependencyProperty.Register("ColumnSpan", typeof(int), typeof(CellField), new PropertyMetadata(1, ColumnSpanPropertyChanged));
        public static readonly DependencyProperty RowSpanProperty = DependencyProperty.Register("RowSpan", typeof(int), typeof(CellField), new PropertyMetadata(1, RowSpanPropertyChanged));

        public CellType Type
        {
            get { return (CellType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }
        public int ColumnSpan
        {
            get { return (int)GetValue(ColumnSpanProperty); }
            set { SetValue(ColumnSpanProperty, value); }
        }
        public int RowSpan
        {
            get { return (int)GetValue(RowSpanProperty); }
            set { SetValue(RowSpanProperty, value); }
        }

        static CellField()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CellField), new FrameworkPropertyMetadata(typeof(CellField)));
        }

        private static void ColumnSpanPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CellField control = (CellField)d;
            control.SetValue(Grid.ColumnSpanProperty, control.ColumnSpan);
        }
        private static void RowSpanPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CellField control = (CellField)d;
            control.SetValue(Grid.RowSpanProperty, control.RowSpan);
        }

        public override ReportObjectModel GetProperties()
        {
            ReportObjectModel obj = new();
            obj.Width = Width;
            obj.CellType = Type;
            obj.FontWeight = FontWeight;
            obj.FontSize = FontSize;
            obj.Width = Width;
            obj.Height = Height;
            obj.RowSpan = RowSpan;
            obj.ColumnSpan = ColumnSpan;
            obj.Content = Content;

            return obj;
        }

        public CellField SetProperties(ReportObjectModel obj)
        {
            Width = obj.Width;
            Height = obj.Height;
            FontWeight = obj.FontWeight;
            FontSize = obj.FontSize;
            FontSize = obj.FontSize;
            Width = obj.Width;
            Height = obj.Height;
            RowSpan = obj.RowSpan;
            ColumnSpan = obj.ColumnSpan;
            Content = obj.Content;
            Type = obj.CellType;

            return this;
        }
    }
}
