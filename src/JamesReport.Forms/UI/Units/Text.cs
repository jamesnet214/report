using JamesReport.Core;
using JamesReport.Data;
using System.Windows;
using System.Windows.Controls;

namespace JamesReport.Forms.UI.Units
{
    public class Text : DragMoveContent
    {
        static Text()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Text), new FrameworkPropertyMetadata(typeof(Text)));
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
            obj.Content = Content;
            obj.Width = 700;
            return obj;
        }

        public Text SetProperties(ReportObjectModel obj)
        {
            Width = obj.Width;
            Height = obj.Height;
            FontWeight = obj.FontWeight;
            FontSize = obj.FontSize;
            Content = string.IsNullOrWhiteSpace(obj.Content?.ToString())  ? "Contract" : obj.Content;

            Canvas.SetTop(this, obj.Top);
            Canvas.SetLeft(this, obj.Left);

            return this;
        }
    }
}
