using System.Windows;

namespace Chapter_10_AdvancedWpf;

/// <summary>
/// Interaction logic for HelpBox.xaml
/// </summary>
public partial class HelpBox : Window
{
	public HelpBox()
		=> InitializeComponent();

	public string PromptDialog()
	{
		base.ShowDialog();
		return this.Email.Text;
	}

	private void Button_Click(object sender, RoutedEventArgs e)
		=> Close();
}