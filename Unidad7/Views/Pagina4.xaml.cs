using Libreria;

namespace Unidad7.Views;

public partial class Pagina4 : ContentPage
{
	public Pagina4()
	{
		InitializeComponent();
	}
	public Pagina4(clsPersona persona)
	{
		InitializeComponent();
		Persona.Text = persona.NombreCompleto.ToString();
	}
}