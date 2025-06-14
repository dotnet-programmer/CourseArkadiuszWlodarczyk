using System.Windows;

namespace Chapter_10_AdvancedWpf;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	public MainWindow()
		=> InitializeComponent();

	private void Btn_10_1_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_01_BindingAndMarkupExtension());

	private void Btn_10_2_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_02_EventsAndDelegates());

	private void Btn_10_3_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_03_DataContextAndINotifyPropertyChanged());

	private void Btn_10_4_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_04_StaticResources_DynamicResources_Source());

	private void Btn_10_5_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_05_GroupBoxAndRadioButton());

	private void Btn_10_6_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_06_Popup());

	private void Btn_10_7_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_07_ToggleButton());

	private void Btn_10_8_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_08_Style());

	private void Btn_10_9_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_09_Triggers());

	private void Btn_10_10_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_10_Converter());

	private void Btn_10_11_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_11_MultiConditionalTrigger());

	private void Btn_10_12_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_12_EventTriggerAndAnimations());

	private void Btn_10_13_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_13_EasingFuncions());

	private void Btn_10_14_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_14_DataTrigger());

	private void Btn_10_15_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_15_ItemSource_ItemsControl_DataTemplate());

	private void Btn_10_16_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_16_UserControl());

	private void Btn_10_17_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_17_CustomDependencyProperty());

	private void Btn_10_18_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_18_Templates_ControlTemplate_ContentPresenter_TemplateBinding());

	private void Btn_10_19_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_19_MultiDataTriggerAndRelativeSource());

	private void Btn_10_20_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_20_ListBoxAndObservableCollection());

	private void Btn_10_21_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_21_ComboBox());

	private void Btn_10_22_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_22_Listview());

	private void Btn_10_23_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_23_ListViewSortingData());

	private void Btn_10_24_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_24_DataGrid());

	private void Btn_10_25_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_25_TemplateSelector());

	private void Btn_10_26_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_26_MenusAndBuiltInCommands());

	private void Btn_10_27_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_27_CustomCommands());

	private void Btn_10_28_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_28_MoreThan1Window());

	private void Btn_10_29_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_29_MessageBoxAndDialogs());

	private void Btn_10_30_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_30_ContextMenuAndCommandParameter());

	private void Btn_10_31_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_31_TooltipAndtoolbar());

	private void Btn_10_32_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_32_Tabs_TabControlAndContentSource());

	private void Btn_10_33_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_33_X_Static());

	private void Btn_10_34_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_34_StringFormat());

	private void Btn_10_35_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_35_MultiBinding_StringFormatAndTargetNullValue());

	private void Btn_10_36_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_36_DispatcherTimer());

	private void Btn_10_37_Click(object sender, RoutedEventArgs e)
		=> ShowWindow(new Chapter_10_37_CalendarAndDatePicker());

	private void ShowWindow(Window window)
		=> window.Show();
}