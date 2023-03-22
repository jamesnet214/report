using JamesReport.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace JamesReport.Core
{
    public abstract class ReportObject : ContentControl
    {
        public abstract ReportObjectModel GetProperties();

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);

         
        }



        public T FindParent<T>(DependencyObject child) where T : IReportCanvas
        {
            DependencyObject parent = VisualTreeHelper.GetParent(child);

            if (parent == null)
                return default(T);

            if (parent is T p)
                return p;

            return FindParent<T>(parent);
        }
    }
}
