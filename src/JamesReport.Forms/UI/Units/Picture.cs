using JamesReport.Core;
using System.Windows;

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
    }
}
