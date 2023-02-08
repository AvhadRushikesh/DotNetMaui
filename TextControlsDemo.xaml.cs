//using Android.OS;
//using System.Diagnostics;

namespace MauiApp1;

public partial class TextControlsDemo : ContentPage
{
	public TextControlsDemo()
	{
		InitializeComponent();
	}

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        //System.Diagnostics.Debug.WriteLine(txtName.Text);
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine(txtName.Text);
    }
}