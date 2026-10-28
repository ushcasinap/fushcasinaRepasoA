namespace fushcasinaRepasoA.Views;

public partial class vDos : ContentPage
{
	public vDos(String usuario)
	{
		InitializeComponent();
		DisplayAlertAsync("Alerta", "Bienvenido" + usuario, "ok");
	}

    private void btnReporte_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Views.vTres(txtDesarrollador.Text, txtAsignatura.Text, txtNivel.Text, txtNota.Text, txtExamen.Text));
    }
}