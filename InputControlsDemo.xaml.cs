namespace MauiApp1;

public partial class InputControlsDemo : ContentPage
{
	public InputControlsDemo()
	{
		InitializeComponent();
	}

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		if (stepper != null)
		{
			lblSlider.Text = slider.Value.ToString();
		}
    }
}