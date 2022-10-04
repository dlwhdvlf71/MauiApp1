using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Class
{
    class IsExitConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.Print("Convert");
            return (int)value != 0;
            //return value.ToString().Equals("input") ? true : false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.Print($"ConvertBack - {value}");
            return (bool)value ? 1 : 0;
            //return value.ToString().Equals("input") ? true : false;
        }
    }
}
