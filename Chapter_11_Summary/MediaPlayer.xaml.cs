using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;

namespace Chapter_11_Summary;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MediaPlayer : Window
{
	private DispatcherTimer? _timer;

	public MediaPlayer()
		=> InitializeComponent();

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		videoClip.ScrubbingEnabled = true;
		videoClip.Stop();
	}

	private void VideoClipPlayHandler(object sender, RoutedEventArgs e)
		=> PlayVideo();

	private void VideoClipPauseHandler(object sender, RoutedEventArgs e)
		=> PauseVideo();

	private void VideoClipStopHandler(object sender, RoutedEventArgs e)
		=> StopVideo();

	private void VideoClip_MediaOpened(object sender, RoutedEventArgs e)
	{
		TimerSlider.Maximum = videoClip.NaturalDuration.TimeSpan.TotalSeconds;

		_timer = new() { Interval = TimeSpan.FromSeconds(1) };
		_timer.Tick += Timer_Tick;

		totalTimeOfVideo.Content = videoClip.NaturalDuration.TimeSpan.ToString(@"hh\:mm\:ss");
	}

	private void VideoClip_MediaFailed(object sender, ExceptionRoutedEventArgs e)
		=> MessageBox.Show(e.ErrorException.Message);

	private void Timer_Tick(object? sender, EventArgs e)
		=> TimerSlider.Value = videoClip.Position.TotalSeconds;

	private void TimerSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		=> videoClip.Position = TimeSpan.FromSeconds(TimerSlider.Value);

	private void TimerSlider_DragStarted(object sender, DragStartedEventArgs e)
		=> PauseVideo();

	private void TimerSlider_DragCompleted(object sender, DragCompletedEventArgs e)
		=> PlayVideo();

	private void PlayVideo()
	{
		videoClip.Play();
		_timer?.Start();
	}

	private void PauseVideo()
	{
		videoClip.Pause();
		_timer?.Stop();
	}

	private void StopVideo()
	{
		videoClip.Stop();
		_timer?.Stop();
	}
}