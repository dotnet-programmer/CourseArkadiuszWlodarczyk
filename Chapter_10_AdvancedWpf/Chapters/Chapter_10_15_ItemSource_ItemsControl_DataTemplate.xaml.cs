using System.Windows;
using Chapter_10_AdvancedWpf.Models;

namespace Chapter_10_AdvancedWpf.Chapters;

public partial class Chapter_10_15_ItemSource_ItemsControl_DataTemplate : Window
{
	public Chapter_10_15_ItemSource_ItemsControl_DataTemplate()
	{
		InitializeComponent();

		List<MyImages> images =
		[
			new(@"Images\logo.png", "Logo"),
			new(@"Images\asfasf.png", "Logo jakiś tekst"),
			new(@"Images\logo.png", "Logo2"),
			new(@"Images\asfasf.png", "Logo jakiś tekst"),
			new(@"Images\logo.png", "Logo2"),
			new(@"Images\logo.png", "Logo2"),
		];

		DataContext = images;
	}
}