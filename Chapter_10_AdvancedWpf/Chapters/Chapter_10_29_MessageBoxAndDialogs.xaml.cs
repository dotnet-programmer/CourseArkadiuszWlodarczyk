using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace Chapter_10_AdvancedWpf.Chapters;

public partial class Chapter_10_29_MessageBoxAndDialogs : Window
{
	public Chapter_10_29_MessageBoxAndDialogs()
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
		//helpBox.ShowDialog();
		//myRichTextBox.AppendText(helpBox.Email.Text);
		string result1 = helpBox.PromptDialog();
		myRichTextBox.AppendText(result1);

		MessageBoxResult result2 = MessageBox.Show(
			"tekst do wypisania", 
			"tytuł okienka", 
			MessageBoxButton.OKCancel, 
			MessageBoxImage.Hand);

		if (result2 == MessageBoxResult.Cancel)
		{
			MessageBox.Show("Anulowales operacje");
		}
		else if (result2 == MessageBoxResult.OK)
		{
			MessageBox.Show("Zgodziles sie na sprzedanie duszy");
		}
		else
		{
			MessageBox.Show("Zrobiles cos innego");
		}
	}

	private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
		=> e.CanExecute = true;
}