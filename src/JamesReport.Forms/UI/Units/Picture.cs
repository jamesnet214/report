﻿using JamesReport.Core;
using JamesReport.Data;
using System.Windows;
using System.Windows.Controls;

namespace JamesReport.Forms.UI.Units
{
    public class Picture : DragMoveContent
    {
        public static readonly DependencyProperty StretchProperty = DependencyProperty.Register("Stretch", typeof(System.Windows.Media.Stretch), typeof(Picture), new PropertyMetadata(System.Windows.Media.Stretch.Uniform));

        public System.Windows.Media.Stretch Stretch
        {
            get { return (System.Windows.Media.Stretch)GetValue(StretchProperty); }
            set { SetValue(StretchProperty, value); }
        }

        static Picture()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Picture), new FrameworkPropertyMetadata(typeof(Picture)));
        }

        public override ReportObjectModel GetProperties()
        {
            ReportObjectModel obj = new();
            obj.Type = this.GetType();
            obj.Width = Width;
            obj.Height = Height;
            obj.FontWeight = FontWeight;
            obj.FontSize = FontSize;
            obj.Stretch = Stretch;
            obj.Top = Canvas.GetTop(this);
            obj.Left = Canvas.GetLeft(this);
            return obj;
        }

        public Picture SetProperties(ReportObjectModel obj)
        {
            Width = obj.Width;
            Height = obj.Height;
            FontWeight = obj.FontWeight;
            FontSize = obj.FontSize;
            Stretch = obj.Stretch;
            Canvas.SetTop(this, obj.Top);
            Canvas.SetLeft(this, obj.Left);

            return this;
        }
    }
}
