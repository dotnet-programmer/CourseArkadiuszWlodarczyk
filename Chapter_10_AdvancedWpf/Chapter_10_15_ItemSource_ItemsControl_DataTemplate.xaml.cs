using System.Windows;

namespace Chapter_10_AdvancedWpf;

/// <summary>
/// Interaction logic for Chapter_10_15_ItemSource_ItemsControl_DataTemplate.xaml
/// </summary>
public partial class Chapter_10_15_ItemSource_ItemsControl_DataTemplate : Window
{
	public Chapter_10_15_ItemSource_ItemsControl_DataTemplate()
	{
		InitializeComponent();

		List<MyImages> images =
		[
			new(@"images\logo.png", "Logo"),
			new(@"images\asfasf.png", "Logo jakiś tekst"),
			new(@"images\logo.png", "Logo2"),
			new(@"images\asfasf.png", "Logo jakiś tekst"),
			new(@"images\logo.png", "Logo2"),
			new(@"images\logo.png", "Logo2"),
		];

		DataContext = images;
	}
}