using System.Collections.ObjectModel;
using System.Windows;
using Chapter_10_AdvancedWpf.Models;

namespace Chapter_10_AdvancedWpf.Chapters;

public partial class Chapter_10_25_TemplateSelector : Window
{
	private readonly ObservableCollection<PersonData2> _listOfPeople = [];

	public Chapter_10_25_TemplateSelector()
	{
		InitializeComponent();

		_listOfPeople.Add(new()
		{
			Name = "Arek",
			Age = 26,
			Email = "videokurspl@gmail.com",
			IsSubscribedToNewsletter = true,
			Website = new Uri("http://videokurs.pl"),
			Image = "videokurspl.png",
			Description = "asas mdmasf amsf amsf asf",
		});

		_listOfPeople.Add(new()
		{
			Name = "Wiola",
			Age = 20,
			Email = "videafsasokurspl@gmail.com",
			GenderType = PersonData2.Gender.Female,
			Description = "asas mdmasf amsf amsf asf",
		});

		_listOfPeople.Add(new()
		{
			Name = "Karol",
			Age = 23,
			Email = "asasas@gmail.com",
			Description = "asas mdmasf amsf amsf asf",
		});

		_listOfPeople.Add(new()
		{
			Name = "Adrian",
			Age = 26,
			Email = "gasdgsdfasdfsas@gafsdfasdil.com",
			Description = "asas mdmasf amsf amsf asf",
		});

		dataGridOfPeople.ItemsSource = _listOfPeople;
		ComboxBoxColumnSex.ItemsSource = Enum.GetValues(typeof(PersonData2.Gender));
	}
}