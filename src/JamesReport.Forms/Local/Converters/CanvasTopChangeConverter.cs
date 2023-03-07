using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace JamesReport.Forms.Local.Converters
{
    public class CanvasTopChangeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is FrameworkElement fe)
            {
                var a = fe.RenderTransform.Value;
                var b = fe.RenderTransformOrigin;

                var c = fe.RenderTransform as TranslateTransform;
                var d = fe.RenderTransform.Value;

                if (fe.RenderTransform is GeneralTransform ge)
                { 
                
                }

                if (fe.RenderTransform is MatrixTransform me)
                {
                    MatrixTransform myTransform = new MatrixTransform();
                    myTransform.Matrix = new Matrix(fe.RenderTransform.Value.M11, fe.RenderTransform.Value.M12, fe.RenderTransform.Value.M21, fe.RenderTransform.Value.M22, 0, 0);

                    fe.RenderTransform = myTransform;
                }

                if (fe.RenderTransform is TranslateTransform te)
                { 
                
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
