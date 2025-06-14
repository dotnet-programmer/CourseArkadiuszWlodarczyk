using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace Chapter_10_AdvancedWpf;

/// <summary>
/// Interaction logic for Chapter_10_27_CustomCommands.xaml
/// </summary>
public partial class Chapter_10_27_CustomCommands : Window
{
	public Chapter_10_27_CustomCommands()
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
}