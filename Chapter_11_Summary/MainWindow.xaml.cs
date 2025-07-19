using System.Windows;
using Chapter_11_Summary.Chapters;

namespace Chapter_11_Summary;

public partial class MainWindow : Window
{
	public MainWindow()
		=> InitializeComponent();

	private void Button_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new MediaPlayer());

	private void Button_Click_1(object sender, RoutedEventArgs e)
		=> ShowWindow(new MediaPlayer2());

	private static void ShowWindow(Window window)
		=> window.Show();
}