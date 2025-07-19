using System.Windows;
using System.Windows.Controls;
using Chapter_10_AdvancedWpf.Models;

namespace Chapter_10_AdvancedWpf.Helpers;

internal class GenderTemplateSelector : DataTemplateSelector
{
	public DataTemplate MaleTemplate { get; set; } = default!;
	public DataTemplate FemaleTemplate { get; set; } = default!;

	public override DataTemplate SelectTemplate(object item, DependencyObject container)
	{
		PersonData2? person = item as PersonData2;
		return person?.GenderType == PersonData2.Gender.Male ? MaleTemplate : FemaleTemplate;
	}
}