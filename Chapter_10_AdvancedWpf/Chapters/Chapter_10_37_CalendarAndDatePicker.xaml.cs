using System.Windows;
using System.Windows.Controls;

namespace Chapter_10_AdvancedWpf.Chapters;

public partial class Chapter_10_37_CalendarAndDatePicker : Window
{
	public Chapter_10_37_CalendarAndDatePicker()
		=> InitializeComponent();

	private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
	{
		if (sender is not Calendar calendar)
		{
			return;
		}

		SelectedDatesCollection selectedDates = calendar.SelectedDates;
		foreach (var item in selectedDates)
		{
			MessageBox.Show(item.ToLocalTime().ToString());
		}
		dateCombo.ItemsSource = selectedDates;
	}
}