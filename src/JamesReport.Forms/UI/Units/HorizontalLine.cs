using JamesReport.Core;
using JamesReport.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace JamesReport.Forms.UI.Units
{
    public class HorizontalLine : DragMoveContent
    {
        static HorizontalLine()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HorizontalLine), new FrameworkPropertyMetadata(typeof(HorizontalLine)));
        }

        public HorizontalLine()
        {
            Width = 700;
            BorderThickness = new Thickness(0, 0, 0, 1);
            Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
        }

        public override ReportObjectModel GetProperties()
        {
            ReportObjectModel obj = new();
            obj.Type = this.GetType();
            obj.Width = Width;
            obj.Height = Height;
            obj.FontWeight = FontWeight;
            obj.FontSize = FontSize;
            obj.BorderThickness = BorderThickness;
            obj.BorderBrush = BorderBrush;
            obj.Background = Background;
            obj.Top = Canvas.GetTop(this);
            obj.Left = Canvas.GetLeft(this);
            return obj;
        }

        public HorizontalLine SetProperties(ReportObjectModel obj)
        {
            Width = obj.Width;
            Height = obj.Height;
            FontWeight = obj.FontWeight;
            FontSize = obj.FontSize;
            BorderThickness = obj.BorderThickness;
            BorderBrush = obj.BorderBrush;
            Background = obj.Background;
            Canvas.SetTop(this, obj.Top);
            Canvas.SetLeft(this, obj.Left);

            return this;
        }
    }
}
