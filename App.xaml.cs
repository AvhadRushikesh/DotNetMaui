namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new AppShell();
        //MainPage = new FirstContentPage();

        var navPage = new NavigationPage(new MainPage());

        navPage.BarBackground = Colors.Chocolate;
        navPage.BarTextColor = Colors.White;

        MainPage = new FlyoutPageDemo();
    }
}
