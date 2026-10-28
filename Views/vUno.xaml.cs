namespace fushcasinaRepasoA.Views;

public partial class vUno : ContentPage
{
    public vUno()
    {
        InitializeComponent();
    }

    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.vDos());
    }
}