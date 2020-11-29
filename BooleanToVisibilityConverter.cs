using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace CarWashBillingSystem.Converter
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
       
            private BooleanToVisibilityConverter _converter = new BooleanToVisibilityConverter();
            private DependencyObject _dummy = new DependencyObject();

            private bool DesignMode
            {
                get
                {
                    return DesignerProperties.GetIsInDesignMode(_dummy);
                }
            }

            #region IValueConverter Members

            public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                if (DesignMode)
                    return Visibility.Visible;
                else
                    return _converter.Convert(value, targetType, parameter, culture);
            }

            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                return _converter.ConvertBack(value, targetType, parameter, culture);
            }

            #endregion
        }
    
}
