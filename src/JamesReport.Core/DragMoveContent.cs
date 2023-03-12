using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Layout;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using System.Windows.Media;

namespace JamesReport.Core
{
    public abstract class DragMoveContent : ReportObject
    {
        private bool isDragging;
        private Point lastPosition;

        public DragMoveContent()
        {
            MouseLeftButtonDown += DraggableRectangle_MouseLeftButtonDown;
            MouseLeftButtonUp += DraggableRectangle_MouseLeftButtonUp;
            MouseMove += DraggableRectangle_MouseMove;

            // ContextMenu 생성
            ContextMenu contextMenu = new ContextMenu();

            // "삭제" 메뉴 아이템 생성
            MenuItem deleteMenuItem = new MenuItem();
            deleteMenuItem.Header = "Delete";
            deleteMenuItem.Click += DeleteMenuItem_Click;

            // ContextMenu에 "삭제" 메뉴 아이템 추가
            contextMenu.Items.Add(deleteMenuItem);

            // ContextMenu를 StackPanel에 연결
            ContextMenuService.SetContextMenu(this, contextMenu);
        }

        private void DraggableRectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDragging = true;
            lastPosition = e.GetPosition(Parent as UIElement);
            CaptureMouse();
        }

        private void DraggableRectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isDragging = false;
            ReleaseMouseCapture();
        }

        private void DraggableRectangle_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentPosition = e.GetPosition(Parent as UIElement);
                double deltaX = currentPosition.X - lastPosition.X;
                double deltaY = currentPosition.Y - lastPosition.Y;

                double newLeft = Canvas.GetLeft(this) + deltaX;
                double newTop = Canvas.GetTop(this) + deltaY;

                // Canvas를 벗어나지 않도록 처리합니다.
                if (newLeft < 0) newLeft = 0;
                if (newTop < 0) newTop = 0;
                if (newLeft + ActualWidth > (Parent as FrameworkElement).ActualWidth)
                    newLeft = (Parent as FrameworkElement).ActualWidth - ActualWidth;
                if (newTop + ActualHeight > (Parent as FrameworkElement).ActualHeight)
                    newTop = (Parent as FrameworkElement).ActualHeight - ActualHeight;

                Canvas.SetLeft(this, newLeft);
                Canvas.SetTop(this, newTop);

                lastPosition = currentPosition;
            }
        }

        // "삭제" 메뉴 아이템 Click 이벤트 처리기
        private void DeleteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // ContextMenu를 호출한 StackPanel에서 선택된 UIElement을 삭제합니다.
            Canvas parentCanvas = VisualTreeHelper.GetParent(this) as Canvas;
            if (parentCanvas != null)
            {
                parentCanvas.Children.Remove(this);

                if (FindParent<IReportCanvas>(parentCanvas) is IReportCanvas p)
                {
                    p.Delete(this);
                }
            }
        }

        public static IReportCanvas FindParent<T>(DependencyObject child) where T : IReportCanvas
        {
            DependencyObject parent = VisualTreeHelper.GetParent(child);

            if (parent == null)
                return null;

            DependencyObject parentElement = parent as DependencyObject;

            if (parent is IReportCanvas p)
            {
                return p;
            }

            return FindParent<T>(parent);
        }
    }
}
