using System.Windows;
using System.Windows.Threading;

namespace Chapter_10_AdvancedWpf;

/// <summary>
/// Interaction logic for Chapter_10_36_DispatcherTimer.xaml
/// </summary>
public partial class Chapter_10_36_DispatcherTimer : Window
{
	private readonly DispatcherTimer _timer = new();

	public Chapter_10_36_DispatcherTimer()
	{
		InitializeComponent();

		_timer.Interval = TimeSpan.FromSeconds(1);
		_timer.Tick += DateTimer;
		_timer.Start();
		actualTime.Content = DateTime.Now.ToLocalTime();
	}

	private void DateTimer(object sender, EventArgs e)
		=> actualTime.Content = DateTime.Now.ToLocalTime();
}