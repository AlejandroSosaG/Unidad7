using Libreria;
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
        public async void Pagina4(object sender, EventArgs e)
        {
            clsPersona persona = new clsPersona();
            persona.Nombre = Nombre.Text;
            persona.Apellidos = Apellidos.Text;
            await Navigation.PushAsync(new Pagina4(persona));
        }
        private async void Pagina5(object sender, EventArgs e)
        {
            clsPersona persona = new clsPersona();
            persona.Nombre = Nombre.Text;
            persona.Apellidos = Apellidos.Text;
            BindingContext = persona;
            await Navigation.PushAsync(new Pagina5(persona));
        }
    }
}