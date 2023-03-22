using JamesReport.Core;
using JamesReport.Models;
using System.Windows;
using System.Windows.Controls;

namespace JamesReport.Forms.UI.Units
{
    public class Header : Text
    {
        static Header()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Header), new FrameworkPropertyMetadata(typeof(Header)));
        }

        public Header()
        {
            FontSize = 40;
            FontWeight = FontWeights.Bold;
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
            return obj;
        }
    }
}
