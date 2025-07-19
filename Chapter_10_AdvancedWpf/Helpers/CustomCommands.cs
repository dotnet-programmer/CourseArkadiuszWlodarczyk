using System.Windows.Input;

namespace Chapter_10_AdvancedWpf.Helpers;

internal class CustomCommands
{
	public static readonly RoutedUICommand Exit = new(
		text: "Exit from app",
		name: "Exit",
		ownerType: typeof(CustomCommands),
		inputGestures: new InputGestureCollection() { new KeyGesture(Key.Q, ModifierKeys.Control) }
		);
}