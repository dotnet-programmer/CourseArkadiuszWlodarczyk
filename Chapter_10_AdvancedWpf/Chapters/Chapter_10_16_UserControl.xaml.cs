using System.Windows;
using Chapter_10_AdvancedWpf.Models;

namespace Chapter_10_AdvancedWpf.Chapters;

public partial class Chapter_10_16_UserControl : Window
{
	public Chapter_10_16_UserControl()
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