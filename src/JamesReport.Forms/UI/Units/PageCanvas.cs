using JamesReport.Core;
using JamesReport.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace JamesReport.Forms.UI.Units
{
    public class PageCanvas : ContentControl
    {
        public static readonly DependencyProperty SelectItemCommandProperty = DependencyProperty.Register("SelectItemCommand", typeof(ICommand), typeof(PageCanvas), new PropertyMetadata(null));
        private Canvas _canvas;

        public ICommand SelectItemCommand
        {
            get { return (ICommand)GetValue(SelectItemCommandProperty); }
            set { SetValue(SelectItemCommandProperty, value); }
        }

        static PageCanvas()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PageCanvas), new FrameworkPropertyMetadata(typeof(PageCanvas)));
        }

        public PageCanvas()
        {
            // Allow Drag and Drop
            AllowDrop = true;
            Drop += ListBox_Drop;
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _canvas = GetTemplateChild("PART_Canvas") as Canvas;
        }

        protected override void OnPreviewMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseLeftButtonUp(e);
        }

        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonUp(e);

            //if (e.OriginalSource is ReportObject ro)
            //{
            //    SelectItemCommand?.Execute(ro);
            //}
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
        }

        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseLeftButtonDown(e);

            if (FindParent<ReportObject>((DependencyObject)e.OriginalSource) is ReportObject ro)
            {
                SelectItemCommand?.Execute(ro);
            }
        }
        public static T FindParent<T>(DependencyObject child) where T : DependencyObject
        {
            DependencyObject parent = VisualTreeHelper.GetParent(child);

            if (parent == null)
                return null;

            T parentElement = parent as T;

            if (parentElement != null)
                return parentElement;
            else
                return FindParent<T>(parent);
        }

        private void ListBox_Drop(object sender, DragEventArgs e)
        {

            if (e.Data.GetData(typeof(ToolItem)) is ToolItem fi)
            {
                ReportObject item = null;

                switch (fi.Name)
                {
                    case "Image": item = new Picture(); break;
                    case "Table": item = new Table(); break;
                    case "Title": item = new Header(); break;
                    case "Horizontal Line": item = new HorizontalLine(); break;
                }

                var p = e.GetPosition(this);
                Canvas.SetLeft(item, p.X);
                Canvas.SetTop(item, p.Y);

                _canvas.Children.Add(item);
            }
        }
    }
}
