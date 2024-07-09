namespace Wetterhub.Views;

public partial class Dashboard : ContentPage
{
	public Dashboard()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		if(BindingContext is Models.Dashboard dashboard)
		{
			dashboard.RefreshWeather();
		}
	}
}