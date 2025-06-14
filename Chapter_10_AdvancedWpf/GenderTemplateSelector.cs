using System.Windows;
using System.Windows.Controls;

namespace Chapter_10_AdvancedWpf;

internal class GenderTemplateSelector : DataTemplateSelector
{
	public DataTemplate MaleTemplate { get; set; }
	public DataTemplate FemaleTemplate { get; set; }

	public override DataTemplate SelectTemplate(object item, DependencyObject container)
	{
		PersonData2 person = item as PersonData2;
		return person.GenderType == PersonData2.Gender.Male ? MaleTemplate : FemaleTemplate;
	}
}