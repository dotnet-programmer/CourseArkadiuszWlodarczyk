using System.Windows;

namespace Chapter_10_AdvancedWpf;

/// <summary>
/// Interaction logic for Chapter_10_26_MenusAndBuiltInCommands.xaml
/// </summary>
public partial class Chapter_10_26_MenusAndBuiltInCommands : Window
{
	public Chapter_10_26_MenusAndBuiltInCommands()
		=> InitializeComponent();

	private void MenuItem_Click(object sender, RoutedEventArgs e)
		=> MessageBox.Show("test");
}