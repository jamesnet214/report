using Jamesnet.Wpf.Controls;
using JamesReport.Core;
using JamesReport.Data;
using Microsoft.VisualBasic;
using System;
using System.Windows;
using System.Windows.Documents;

namespace JamesReport.Forms.UI.Units
{
    public class Table : DragMoveContent
    {
        public static readonly DependencyProperty RowsProperty = DependencyProperty.Register("Rows", typeof(string), typeof(Table), new PropertyMetadata("", RowsPropertyChanged));
        public static readonly DependencyProperty ColumnsProperty = DependencyProperty.Register("Columns", typeof(string), typeof(Table), new PropertyMetadata("", ColumnsPropertyChanged));
        private JamesGrid _grid;

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

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _grid = GetTemplateChild("PART_JamesGrid") as JamesGrid;
            _grid.Rows = Rows;
            _grid.Columns = Columns;
        }

        private static void RowsPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                Table table = (Table)d;
                table._grid.Rows = e.NewValue.ToString();
            }
            catch
            { 
            
            }
        }

        private static void ColumnsPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                Table table = (Table)d;
                table._grid.Columns = e.NewValue.ToString();
            }
            catch
            { 
            
            }
        }
    }
}
