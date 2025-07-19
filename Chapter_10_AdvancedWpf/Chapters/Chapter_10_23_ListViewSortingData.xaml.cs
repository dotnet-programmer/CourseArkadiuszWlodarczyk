using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Chapter_10_AdvancedWpf.Models;

namespace Chapter_10_AdvancedWpf.Chapters;

public partial class Chapter_10_23_ListViewSortingData : Window
{
	private readonly ObservableCollection<PersonData> _listOfNames = [];

	public Chapter_10_23_ListViewSortingData()
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
		PersonData selectedName = (PersonData)ListOfNames.SelectedItem;
		if (selectedName != null)
		{
			_listOfNames.Remove(selectedName);
		}
	}

	private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
	{
		GridViewColumnHeader? header = sender as GridViewColumnHeader;
		string? columnNameToSort = header?.Content.ToString();

		CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListOfNames.ItemsSource);
		ListSortDirection howToSort = ListSortDirection.Ascending;

		if (view.SortDescriptions.Any())
		{
			SortDescription sortDescription = view.SortDescriptions.ElementAt(0);
			if (columnNameToSort == sortDescription.PropertyName.ToString())
			{
				howToSort = sortDescription.Direction == ListSortDirection.Ascending
					? ListSortDirection.Descending
					: ListSortDirection.Ascending;
			}
		}
		view.SortDescriptions.Clear();
		view.SortDescriptions.Add(new SortDescription(columnNameToSort, howToSort));
	}
}