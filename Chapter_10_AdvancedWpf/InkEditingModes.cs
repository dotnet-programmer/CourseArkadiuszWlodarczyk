using System.ComponentModel;
using System.Windows.Controls;

namespace Chapter_10_AdvancedWpf;

internal class InkEditingModes : INotifyPropertyChanged
{
	private InkCanvasEditingMode _editingMode;

	public InkEditingModes()
		=> _editingMode = InkCanvasEditingMode.Ink;

	public event PropertyChangedEventHandler? PropertyChanged;

	public InkCanvasEditingMode EditingMode
	{
		get => _editingMode;
		set
		{
			_editingMode = value;
			OnPropertyChanged(nameof(EditingMode));
		}
	}

	public void OnPropertyChanged(string propertyName)
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}