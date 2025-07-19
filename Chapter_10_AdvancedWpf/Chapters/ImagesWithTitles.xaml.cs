using System.Windows.Controls;

namespace Chapter_10_AdvancedWpf.Chapters;

public partial class ImagesWithTitles : UserControl
{
	private double _controlWidth;

	public ImagesWithTitles() 
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
}