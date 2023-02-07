namespace MauiApp1;

public partial class FirstContentPage : ContentPage
{
	public FirstContentPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}