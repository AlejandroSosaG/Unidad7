namespace Unidad7.Views
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedPage());
        }
        private async void Pagina4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina4());
        }
        private async void Pagina5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina5());
        }
    }
}