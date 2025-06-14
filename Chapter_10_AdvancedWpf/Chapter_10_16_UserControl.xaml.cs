using System.Windows;

namespace Chapter_10_AdvancedWpf;

/// <summary>
/// Interaction logic for Chapter_10_16_UserControl.xaml
/// </summary>
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