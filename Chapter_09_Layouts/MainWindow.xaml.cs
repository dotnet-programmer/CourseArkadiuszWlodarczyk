using System.Windows;
using Chapter_09_Layouts.Chapters;

namespace Chapter_09_Layouts;

public partial class MainWindow : Window
{
	public MainWindow() 
		=> InitializeComponent();

	private void Btn_9_1_Click(object sender, RoutedEventArgs e) 
		=> ShowWindow(new Chapter_9_1_LayoutsAndAttachedProperty());

	private void Btn_9_2_Click(object sender, RoutedEventArgs e) 
		=> ShowWindow(new Chapter_9_2_GridSplitter());

	private void Btn_9_3_Click(object sender, RoutedEventArgs e) 
		=> ShowWindow(new Chapter_9_3_UniformGrid());

	private void Btn_9_4_Click(object sender, RoutedEventArgs e) 
		=> ShowWindow(new Chapter_9_4_StackPanelAndWrapPanel());

	private void Btn_9_5_Click(object sender, RoutedEventArgs e) 
		=> ShowWindow(new Chapter_9_5_DockPanel());

	private void Btn_9_6_Click(object sender, RoutedEventArgs e) 
		=> ShowWindow(new Chapter_9_6_Canvas());

	private void Btn_9_7_Click(object sender, RoutedEventArgs e) 
		=> ShowWindow(new Chapter_9_7_ScrollViewerAndTextWrapping());

	private void Btn_9_8_Click(object sender, RoutedEventArgs e) 
		=> ShowWindow(new Chapter_9_8_Expander());

	private void Btn_9_9_Click(object sender, RoutedEventArgs e) 
		=> ShowWindow(new Chapter_9_9_RadioButton_GroupBox_Label());

	private static void ShowWindow(Window window)
		=> window.Show();
}