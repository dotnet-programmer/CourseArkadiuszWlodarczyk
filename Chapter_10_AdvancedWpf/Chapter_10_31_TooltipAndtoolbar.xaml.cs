using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace Chapter_10_AdvancedWpf;

/// <summary>
/// Interaction logic for Chapter_10_31_TooltipAndtoolbar.xaml
/// </summary>
public partial class Chapter_10_31_TooltipAndtoolbar : Window
{
	public Chapter_10_31_TooltipAndtoolbar()
	{
		EditingCommands.IncreaseFontSize.InputGestures.Add(new KeyGesture(Key.F3, ModifierKeys.Shift | ModifierKeys.Control));
		ApplicationCommands.Copy.InputGestures.Clear();
		ApplicationCommands.Copy.InputGestures.Add(new KeyGesture(Key.Q, ModifierKeys.Alt));
		InitializeComponent();
	}

	private void MenuItem_Click(object sender, RoutedEventArgs e)
		=> MessageBox.Show("test");

	private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		=> e.CanExecute = true;

	private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
		=> Application.Current.Shutdown();

	private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
		=> e.CanExecute = true;

	private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
	{
		MessageBoxResult result = MessageBox.Show("tekst do wypisania", "tytuł okienka", MessageBoxButton.OKCancel, MessageBoxImage.Hand);
		if (result == MessageBoxResult.Cancel)
		{
			MessageBox.Show("Anulowales operacje");
		}
		else if (result == MessageBoxResult.OK)
		{
			MessageBox.Show("Zgodziles sie na sprzedanie duszy");
		}
		else
		{
			MessageBox.Show("Zrobiles cos innego");
		}
	}
}