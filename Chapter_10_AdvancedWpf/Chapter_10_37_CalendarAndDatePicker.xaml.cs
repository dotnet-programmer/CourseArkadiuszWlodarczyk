using System.Windows;
using System.Windows.Controls;

namespace Chapter_10_AdvancedWpf;

/// <summary>
/// Interaction logic for Chapter_10_37_CalendarAndDatePicker.xaml
/// </summary>
public partial class Chapter_10_37_CalendarAndDatePicker : Window
{
	public Chapter_10_37_CalendarAndDatePicker()
		=> InitializeComponent();

	private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
	{
		Calendar calendar = sender as Calendar;
		SelectedDatesCollection selectedDates = calendar.SelectedDates;
		foreach (var item in selectedDates)
		{
			MessageBox.Show(item.ToLocalTime().ToString());
		}
		dateCombo.ItemsSource = selectedDates;
	}
}