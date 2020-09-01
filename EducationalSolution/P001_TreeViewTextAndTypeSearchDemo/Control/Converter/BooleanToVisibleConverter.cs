using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace P001_TreeViewTextAndTypeSearchDemo.Control.Converter
{
    public class BooleanToVisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && (bool)value ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
