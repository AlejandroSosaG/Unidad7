namespace Unidad7.Views;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}
	private async void OnClicked(object sender, EventArgs e)
	{
		await Navigation.PopToRootAsync();
	}
}