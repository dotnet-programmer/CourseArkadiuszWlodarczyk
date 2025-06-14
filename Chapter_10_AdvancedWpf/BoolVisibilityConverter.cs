using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Chapter_10_AdvancedWpf;

[ValueConversion(typeof(bool), typeof(Visibility))]
internal class BoolVisibilityConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		=> (bool)value == true ? Visibility.Visible : Visibility.Collapsed;

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		=> (Visibility)value != Visibility.Collapsed;
}