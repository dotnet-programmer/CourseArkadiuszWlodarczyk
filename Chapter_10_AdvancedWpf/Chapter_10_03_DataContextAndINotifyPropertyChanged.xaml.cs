using System.Windows;
using System.Windows.Controls;

namespace Chapter_10_AdvancedWpf;

/// <summary>
/// Interaction logic for Chapter_10_03_DataContextAndINotifyPropertyChanged.xaml
/// </summary>
public partial class Chapter_10_03_DataContextAndINotifyPropertyChanged : Window
{
	private readonly InkEditingModes _editingModes = new();

	public Chapter_10_03_DataContextAndINotifyPropertyChanged()
	{
		InitializeComponent();
		DataContext = _editingModes;
	}

	private void Drawing_Click(object sender, RoutedEventArgs e)
		=> _editingModes.EditingMode = InkCanvasEditingMode.Ink;

	private void Selection_Click(object sender, RoutedEventArgs e)
		=> _editingModes.EditingMode = InkCanvasEditingMode.Select;
}