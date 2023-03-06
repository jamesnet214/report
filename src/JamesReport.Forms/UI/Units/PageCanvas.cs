using JamesReport.Core;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace JamesReport.Forms.UI.Units
{
    public class PageCanvas : ContentControl
    {
        public static readonly DependencyProperty SelectItemCommandProperty = DependencyProperty.Register("SelectItemCommand", typeof(ICommand), typeof(PageCanvas), new PropertyMetadata(null));
       
        public ICommand SelectItemCommand
        {
            get { return (ICommand)GetValue(SelectItemCommandProperty); }
            set { SetValue(SelectItemCommandProperty, value); }
        }

        static PageCanvas()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PageCanvas), new FrameworkPropertyMetadata(typeof(PageCanvas)));
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
    }
}
