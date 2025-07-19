using System.Globalization;
using System.Windows.Data;

namespace Chapter_11_Summary.Helpers;

[ValueConversion(typeof(double), typeof(TimeSpan))]
internal class SecondsTimeSpanConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture) 
		=> TimeSpan.FromSeconds((double)value).ToString(@"hh\:mm\:ss");

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		=> throw new NotImplementedException();
}