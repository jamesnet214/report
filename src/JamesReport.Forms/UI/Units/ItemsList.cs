using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace JamesReport.Forms.UI.Units
{
    public class ItemsList : ListBox
    {
        static ItemsList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemsList), new FrameworkPropertyMetadata(typeof(ItemsList)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new ItemsListItem();
        }

        private object dragData;

        public ItemsList()
        {
            DragEnter += ListBox_DragEnter;
            DragLeave += ListBox_DragLeave;
            DragOver += ListBox_DragOver;
        }

        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBoxItem)))
            {
                e.Effects = DragDropEffects.Move;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void ListBox_DragLeave(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.None;
        }

        private void ListBox_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBoxItem)))
            {
                e.Effects = DragDropEffects.Move;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }

        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseLeftButtonDown(e);

            if (e.OriginalSource is FrameworkElement fe)
            {
                dragData = fe.DataContext;
                DragDrop.DoDragDrop(this, dragData, DragDropEffects.Move);
            }
        }
    }
}
