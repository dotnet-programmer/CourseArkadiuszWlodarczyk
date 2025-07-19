using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace Chapter_10_AdvancedWpf.Chapters;

public partial class Chapter_10_28_MoreThan1Window : Window
{
	public Chapter_10_28_MoreThan1Window()
	{
		EditingCommands.IncreaseFontSize.InputGestures.Add(new KeyGesture(Key.F3, ModifierKeys.Shift | ModifierKeys.Control));
		ApplicationCommands.Copy.InputGestures.Clear();
		ApplicationCommands.Copy.InputGestures.Add(new KeyGesture(Key.Q, ModifierKeys.Alt));

		InitializeComponent();
	}

	private void MenuItem_Click(object sender, RoutedEventArgs e)
		=> MessageBox.Show("test");

	private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
		=> Application.Current.Shutdown();

	private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		=> e.CanExecute = true;

	private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
	{
		HelpBox helpBox = new();
		helpBox.ShowDialog();
	}

	private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
		=> e.CanExecute = true;
}