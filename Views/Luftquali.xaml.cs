namespace Wetterhub.Views;

public partial class Luftquali : ContentPage
{
	public Luftquali()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Luftquali luftquali)
        {
            luftquali.RefreshWeather();
        }
    }
}