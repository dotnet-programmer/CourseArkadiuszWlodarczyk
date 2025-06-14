using System.Globalization;
using System.Windows.Data;

namespace Chapter_11_Summary;

internal class TwoValuesPercentageConverter : IMultiValueConverter
{
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		double watchedTime = (double)values[0];
		double totalTime = (double)values[1];
		return watchedTime / totalTime;
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) 
		=> throw new NotImplementedException();
}