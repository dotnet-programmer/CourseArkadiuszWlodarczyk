using System.Collections.ObjectModel;
using System.Windows;

namespace Chapter_10_AdvancedWpf;

/// <summary>
/// Interaction logic for Chapter_10_21_ComboBox.xaml
/// </summary>
public partial class Chapter_10_21_ComboBox : Window
{
	private readonly ObservableCollection<string> _listOfNames = [];

	public Chapter_10_21_ComboBox()
	{
		InitializeComponent();

		_listOfNames.Add("Arek");
		_listOfNames.Add("Wiola");
		_listOfNames.Add("Karol");
		ListOfNames.ItemsSource = _listOfNames;
	}

	private void Button_Click(object sender, RoutedEventArgs e) 
		=> _listOfNames.Add(NameToAdd.Text);

	private void Button_Click_1(object sender, RoutedEventArgs e)
	{
		int selectedNameIndex = ListOfNames.SelectedIndex;
		if (selectedNameIndex != -1)
		{
			_listOfNames.RemoveAt(selectedNameIndex);
		}
	}
}