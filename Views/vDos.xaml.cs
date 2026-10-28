namespace fushcasinaRepasoA.Views;

public partial class vDos : ContentPage
{
    public vDos(string usuario)
    {
        InitializeComponent();

        DisplayAlertAsync("Alerta", "Bienvenido " + usuario, "OK");
    }

    private async void btnReporte_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(
            new Views.vTres(
                txtDesarrollador.Text,
                txtAsignatura.Text,
                txtNivel.Text,
                txtExamen.Text,
                txtNota.Text
            ));
    }
}