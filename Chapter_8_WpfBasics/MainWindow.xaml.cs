using System.Windows;

namespace Chapter_8_WpfBasics;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	public int Counter { get; private set; }

	public MainWindow()
	{
		InitializeComponent();
		Counter = 0;
	}

	private void Add_Click(object sender, RoutedEventArgs e)
		=> label_content.Content = Counter++;

	private void Button_Click(object sender, RoutedEventArgs e)
		=> MessageBox.Show("TEST");
}