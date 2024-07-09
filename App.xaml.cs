namespace Wetterhub;

public partial class App : Application
{
	public App()
	{
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("OTgxNTQzQDMyMzAyZTM0MmUzMGozSkpXejAvU1JIek8xanhhNnB5NnhrejZjSGdYbThUdlJTejNZNEZVZ0E9");

        InitializeComponent();

		MainPage = new AppShell();
	}
}
