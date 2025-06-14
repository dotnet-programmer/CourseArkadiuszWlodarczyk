using System.Windows;

namespace Chapter_11_Summary;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	public MainWindow() => InitializeComponent();

	private void Button_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new MediaPlayer());

	private void Button_Click_1(object sender, RoutedEventArgs e)
		=> ShowWindow(new MediaPlayer2());

	private void ShowWindow(Window window)
		=> window.Show();
}