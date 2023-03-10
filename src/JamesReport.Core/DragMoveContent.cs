using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Layout;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace JamesReport.Core
{
    public class DragMoveContent : ReportObject
    {
        private bool isDragging;
        private Point lastPosition;

        public DragMoveContent()
        {
            MouseLeftButtonDown += DraggableRectangle_MouseLeftButtonDown;
            MouseLeftButtonUp += DraggableRectangle_MouseLeftButtonUp;
            MouseMove += DraggableRectangle_MouseMove;
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
    }
}
