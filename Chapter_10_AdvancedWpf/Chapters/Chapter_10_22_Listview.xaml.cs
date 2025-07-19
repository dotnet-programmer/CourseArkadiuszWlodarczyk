using System.Collections.ObjectModel;
using System.Windows;
using Chapter_10_AdvancedWpf.Models;

namespace Chapter_10_AdvancedWpf.Chapters;

public partial class Chapter_10_22_Listview : Window
{
	private readonly ObservableCollection<PersonData> _listOfNames = [];

	public Chapter_10_22_Listview()
	{
		InitializeComponent();

		_listOfNames.Add(new() { Name = "Arek", Age = 26, Email = "videokurspl@gmail.com" });
		_listOfNames.Add(new() { Name = "Wiola", Age = 20, Email = "asdfasdf@gmail.com" });
		_listOfNames.Add(new() { Name = "Karol", Age = 23, Email = "asdfasdg@gmail.com" });
		ListOfNames.ItemsSource = _listOfNames;
	}

	private void Button_Click(object sender, RoutedEventArgs e)
		=> _listOfNames.Add(new() { Name = NameToAdd.Text, Age = Convert.ToInt32(AgeToAdd.Text), Email = EmailToAdd.Text });

	private void Button_Click_1(object sender, RoutedEventArgs e)
	{
		int selectedNameIndex = ListOfNames.SelectedIndex;
		if (selectedNameIndex != -1)
		{
			_listOfNames.RemoveAt(selectedNameIndex);
		}
	}
}