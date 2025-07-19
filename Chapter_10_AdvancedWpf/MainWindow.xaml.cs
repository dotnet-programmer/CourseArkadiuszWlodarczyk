using System.Windows;
using System.Windows.Controls;
using Chapter_10_AdvancedWpf.Chapters;

namespace Chapter_10_AdvancedWpf;

public partial class MainWindow : Window
{
	public MainWindow()
		=> InitializeComponent();

	private void BtnClick(object sender, RoutedEventArgs e)
	{
		if (e.OriginalSource is not Button button)
		{
			return;
		}

		int index = button.Name.LastIndexOf('_') + 1;
		int number = int.Parse(button.Name[index..]);
		_ = number switch
		{
			1 => ShowWindow(new Chapter_10_01_BindingAndMarkupExtension()),
			2 => ShowWindow(new Chapter_10_02_EventsAndDelegates()),
			3 => ShowWindow(new Chapter_10_03_DataContextAndINotifyPropertyChanged()),
			4 => ShowWindow(new Chapter_10_04_StaticResources_DynamicResources_Source()),
			5 => ShowWindow(new Chapter_10_05_GroupBoxAndRadioButton()),
			6 => ShowWindow(new Chapter_10_06_Popup()),
			7 => ShowWindow(new Chapter_10_07_ToggleButton()),
			8 => ShowWindow(new Chapter_10_08_Style()),
			9 => ShowWindow(new Chapter_10_09_Triggers()),
			10 => ShowWindow(new Chapter_10_10_Converter()),
			11 => ShowWindow(new Chapter_10_11_MultiConditionalTrigger()),
			12 => ShowWindow(new Chapter_10_12_EventTriggerAndAnimations()),
			13 => ShowWindow(new Chapter_10_13_EasingFuncions()),
			14 => ShowWindow(new Chapter_10_14_DataTrigger()),
			15 => ShowWindow(new Chapter_10_15_ItemSource_ItemsControl_DataTemplate()),
			16 => ShowWindow(new Chapter_10_16_UserControl()),
			17 => ShowWindow(new Chapter_10_17_CustomDependencyProperty()),
			18 => ShowWindow(new Chapter_10_18_Templates_ControlTemplate_ContentPresenter_TemplateBinding()),
			19 => ShowWindow(new Chapter_10_19_MultiDataTriggerAndRelativeSource()),
			20 => ShowWindow(new Chapter_10_20_ListBoxAndObservableCollection()),
			21 => ShowWindow(new Chapter_10_21_ComboBox()),
			22 => ShowWindow(new Chapter_10_22_Listview()),
			23 => ShowWindow(new Chapter_10_23_ListViewSortingData()),
			24 => ShowWindow(new Chapter_10_24_DataGrid()),
			25 => ShowWindow(new Chapter_10_25_TemplateSelector()),
			26 => ShowWindow(new Chapter_10_26_MenusAndBuiltInCommands()),
			27 => ShowWindow(new Chapter_10_27_CustomCommands()),
			28 => ShowWindow(new Chapter_10_28_MoreThan1Window()),
			29 => ShowWindow(new Chapter_10_29_MessageBoxAndDialogs()),
			30 => ShowWindow(new Chapter_10_30_ContextMenuAndCommandParameter()),
			31 => ShowWindow(new Chapter_10_31_TooltipAndtoolbar()),
			32 => ShowWindow(new Chapter_10_32_Tabs_TabControlAndContentSource()),
			33 => ShowWindow(new Chapter_10_33_X_Static()),
			34 => ShowWindow(new Chapter_10_34_StringFormat()),
			35 => ShowWindow(new Chapter_10_35_MultiBinding_StringFormatAndTargetNullValue()),
			36 => ShowWindow(new Chapter_10_36_DispatcherTimer()),
			37 => ShowWindow(new Chapter_10_37_CalendarAndDatePicker()),
			_ => false
		};
	}

	private static bool? ShowWindow(Window window)
	{
		window.Show();
		return false;
	}
}