using System.Windows;

namespace Chapter_10_AdvancedWpf;

/// <summary>
/// Interaction logic for Chapter_10_01_BindingAndMarkupExtension.xaml
/// </summary>
public partial class Chapter_10_01_BindingAndMarkupExtension : Window
{
	public Chapter_10_01_BindingAndMarkupExtension()
		=> InitializeComponent();

	private void Button_Click(object sender, RoutedEventArgs e)
		=> TextBlockWithText.Text = "to jest zmiana";
}