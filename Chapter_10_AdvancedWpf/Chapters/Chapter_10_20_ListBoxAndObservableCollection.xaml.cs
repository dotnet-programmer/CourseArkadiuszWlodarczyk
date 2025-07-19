using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Chapter_10_AdvancedWpf.Chapters;

public partial class Chapter_10_20_ListBoxAndObservableCollection : Window
{
	private readonly ObservableCollection<string> _listOfNames = [];

	public Chapter_10_20_ListBoxAndObservableCollection()
	{
		InitializeComponent();

		_listOfNames.Add("Arek");
		_listOfNames.Add("Wiola");
		_listOfNames.Add("Karol");
		ListOfNames.ItemsSource = _listOfNames;
	}

	private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//MessageBox.Show(ListOfNames.SelectedIndex.ToString());
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		_listOfNames.Add(NameToAdd.Text);

		// ListOfNames.Items.Add(NameToAdd.Text);
	}

	private void Button_Click_1(object sender, RoutedEventArgs e)
	{
		int selectedNameIndex = ListOfNames.SelectedIndex;

		if (selectedNameIndex != -1)
		{
			_listOfNames.RemoveAt(selectedNameIndex);

			//ListOfNames.Items.RemoveAt(selectedNameIndex);
		}
	}
}