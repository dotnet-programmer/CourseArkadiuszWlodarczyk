using System.Windows;

namespace Chapter_08_WpfBasics;

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