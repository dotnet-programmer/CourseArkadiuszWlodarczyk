using System.Windows;
using System.Windows.Controls;
using Chapter_10_AdvancedWpf.Helpers;

namespace Chapter_10_AdvancedWpf.Chapters;

public partial class Chapter_10_04_StaticResources_DynamicResources_Source : Window
{
	public Chapter_10_04_StaticResources_DynamicResources_Source() 
		=> InitializeComponent();

	private void Drawing_Click(object sender, RoutedEventArgs e)
	{
		// obiekt InkEditingModes w zasobach okna
		if (Resources["inkEditingModes"] is InkEditingModes inkEditingModes)
		{
			inkEditingModes.EditingMode = InkCanvasEditingMode.Ink;
		}

		// obiekt InkEditingModes w zasobach aplikacji
		//if (Application.Current.Resources["inkEditingModes"] is InkEditingModes inkEditingModes)
		//{
		//	inkEditingModes.EditingMode = InkCanvasEditingMode.Ink;
		//}
	}

	private void Selection_Click(object sender, RoutedEventArgs e)
	{
		// obiekt InkEditingModes w zasobach okna
		if (Resources["inkEditingModes"] is InkEditingModes inkEditingModes)
		{
			inkEditingModes.EditingMode = InkCanvasEditingMode.Select;
		}

		// obiekt InkEditingModes w zasobach aplikacji
		//if (Application.Current.Resources["inkEditingModes"] is InkEditingModes inkEditingModes)
		//{
		//	inkEditingModes.EditingMode = InkCanvasEditingMode.Select;
		//}
	}
}