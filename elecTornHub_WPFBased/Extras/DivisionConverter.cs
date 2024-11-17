using System;
using System.Globalization;
using System.Windows.Data;

namespace elecTornHub_WPFBased.Extras
{
    public class DivisionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double number && parameter is double divisor)
            {
                return number / divisor;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}