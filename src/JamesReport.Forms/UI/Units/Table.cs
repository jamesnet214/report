using Jamesnet.Wpf.Controls;
using JamesReport.Core;
using JamesReport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace JamesReport.Forms.UI.Units
{
    public class Table : DragMoveContent
    {
        public static readonly DependencyProperty ItemsCountProperty = DependencyProperty.Register("ItemsCount", typeof(int), typeof(Table), new PropertyMetadata(0, ItemsCountPropertyChanged));
        public static readonly DependencyProperty AddCellFieldCommandProperty = DependencyProperty.Register("AddCellFieldCommand", typeof(ICommand), typeof(Table), new PropertyMetadata(null));
        public static readonly DependencyProperty RowsProperty = DependencyProperty.Register("Rows", typeof(string), typeof(Table), new PropertyMetadata(""));
        public static readonly DependencyProperty ColumnsProperty = DependencyProperty.Register("Columns", typeof(string), typeof(Table), new PropertyMetadata(""));
        private JamesGrid _grid;
        private List<ReportObjectModel> _cellFields;

        public int ItemsCount
        {
            get { return (int)GetValue(ItemsCountProperty); }
            set { SetValue(ItemsCountProperty, value); }
        }

        public ICommand AddCellFieldCommand
        {
            get { return (ICommand)GetValue(AddCellFieldCommandProperty); }
            set { SetValue(AddCellFieldCommandProperty, value); }
        }

        public string Rows
        {
            get { return (string)GetValue(RowsProperty); }
            set { SetValue(RowsProperty, value); }
        }

        public string Columns
        {
            get { return (string)GetValue(ColumnsProperty); }
            set { SetValue(ColumnsProperty, value); }
        }

        static Table()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Table), new FrameworkPropertyMetadata(typeof(Table)));
        }

        public override ReportObjectModel GetProperties()
        {
            ReportObjectModel obj = new();
            obj.Type = this.GetType();
            obj.Width = Width;
            obj.Height = Height;
            obj.FontWeight = FontWeight;
            obj.FontSize = FontSize;
            obj.Top = Canvas.GetTop(this);
            obj.Left = Canvas.GetLeft(this);
            obj.Rows = Rows;
            obj.Columns = Columns;
            obj.CellFields = new();

            if (_grid != null)
            {
                foreach (ReportObject item in _grid.Children)
                {
                    var cellField = item.GetProperties();
                    obj.CellFields.Add(cellField);
                }
            }

            return obj;
        }

        public Table SetProperties(ReportObjectModel obj)
        {
            Width = obj.Width;
            Height = obj.Height;
            FontWeight = obj.FontWeight;
            FontSize = obj.FontSize;
            Rows = obj.Rows;
            Columns = obj.Columns;
            Canvas.SetTop(this, obj.Top);
            Canvas.SetLeft(this, obj.Left);

            _cellFields = obj.CellFields;
            return this;
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _grid = GetTemplateChild("PART_JamesGrid") as JamesGrid;
            _grid.Rows = Rows;
            _grid.Columns = Columns;

            if (_cellFields != null)
            {
                foreach (var item in _cellFields)
                {
                    _grid.Children.Add(new CellField().SetProperties(item));
                }
            }
        }

        private static void ItemsCountPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Table table = (Table)d;
            if (table._grid != null)
            {
                table.SetCellField();
            }
        }

        private void SetCellField()
        {
            int count = _grid.Children.Count;

            if (count > ItemsCount || count == ItemsCount)
            {
                return;
            }

            List<CellField> fields = new();
            foreach (CellField item in _grid.Children)
            {
                fields.Add(item);
            }
            _grid.Children.Clear();

            for (int i = 0; i < ItemsCount; i++)
            {
                if (fields.FirstOrDefault() is CellField cf)
                {
                    fields.Remove(cf);
                    _grid.Children.Add(cf);
                }
                else
                {
                    _grid.Children.Add(new CellField { Type = CellType.Label, Content = (i + 1).ToString() });
                }
            }
        }
    }
}
