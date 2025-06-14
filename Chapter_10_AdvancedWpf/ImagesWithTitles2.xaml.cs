using System.Windows;
using System.Windows.Controls;

namespace Chapter_10_AdvancedWpf;

/// <summary>
/// Interaction logic for ImagesWithTitles2.xaml
/// </summary>
public partial class ImagesWithTitles2 : UserControl
{
	// DependencyProperty (właściwość zależna) jest wymagane, jeśli jakaś właściwość ma być celem Bindingu
	// posiada wbudowany PropertyChanged do informowania o zmianach 
	// nazwa tego pola powinna być taka jak właściwość do której się odnosi + "Property"
	// po ustawieniu Bindingu do DependencyProperty, Setter z właściwości nie jest wywoływany,
	//	tylko działa wewnętrzny system SetValue, żeby to obsłużyć, trzeba dodać parametr "typeMetadata"
	public static readonly DependencyProperty ImagesSourceProperty = DependencyProperty.Register(
		name: nameof(ImagesSource), // nazwa właściwości do której robione jest DependencyProperty
		propertyType: typeof(List<MyImages2>), // typ właściwości
		ownerType: typeof(ImagesWithTitles2), // kto posiada to DependencyProperty
		
		// opcjonalnie - wewnętrzny mechanizm powiadamiania
		typeMetadata: new FrameworkPropertyMetadata(
			// domyślna wartość DependencyProperty
			defaultValue: null, 

			// funkcja, która ma zostać wykonana po wykryciu powiadomienia o zmianie
			propertyChangedCallback: new PropertyChangedCallback(
				// tutaj funkcja anonimowa, można też zrobić zwykłą metodę i tutaj wpisać tylko jej nazwę
				// source - źródło wywołania, czyli tam gdzie znajduje się DependencyObject, tutaj ImagesWithTitles2
				// e - argumenty - wartość, która została zmieniona i tutaj można pobrać starą wartość która była albo nową wartość
				(source, e) => { (source as ImagesWithTitles2).CustomItemsControl.ItemsSource = (List<MyImages2>)e.NewValue; }))
	);

	private double _controlWidth;

	public ImagesWithTitles2()
		=> InitializeComponent();

	public double ControlWidth
	{
		get => _controlWidth;
		set
		{
			_controlWidth = value;
			Width = _controlWidth / 2;
		}
	}

	public List<MyImages2> ImagesSource
	{
		get => (List<MyImages2>)GetValue(ImagesSourceProperty);
		set => SetValue(ImagesSourceProperty, value);
	}
}