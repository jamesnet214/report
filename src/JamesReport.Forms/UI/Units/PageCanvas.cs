using JamesReport.Core;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

            if (e.OriginalSource is DragMoveContent dmc)
            {
                SelectItemCommand?.Execute(dmc);
            }
        }
    }
}
