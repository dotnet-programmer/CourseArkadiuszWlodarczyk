using System.Windows;
using System.Windows.Controls;
using Chapter_10_AdvancedWpf.Helpers;

namespace Chapter_10_AdvancedWpf.Chapters;

public partial class Chapter_10_03_DataContextAndINotifyPropertyChanged : Window
{
	private readonly InkEditingModes _editingModes = new();

	public Chapter_10_03_DataContextAndINotifyPropertyChanged()
	{
		InitializeComponent();
		DataContext = _editingModes;
	}

	private void Selection_Click(object sender, RoutedEventArgs e)
		=> _editingModes.EditingMode = InkCanvasEditingMode.Select;

	private void Drawing_Click(object sender, RoutedEventArgs e)
		=> _editingModes.EditingMode = InkCanvasEditingMode.Ink;
}