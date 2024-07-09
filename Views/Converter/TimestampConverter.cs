using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterhub.Views.Converter
{
    internal class TimestampConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DateTimeOffset.FromUnixTimeSeconds((int)value).LocalDateTime.ToString("dd. MMMM yyyy - HH:mm");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((DateTimeOffset)DateTime.Parse((string)value)).ToUnixTimeSeconds();
        }
    }
}
