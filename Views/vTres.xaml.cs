namespace fushcasinaRepasoA.Views;

public partial class vTres : ContentPage
{
    public vTres(string desarrollo, string asignatura, string nivel, string examen, string nota)
    {
        InitializeComponent();

        txtDesarrollado.Text = desarrollo;
        txtAsignatura.Text = asignatura;
        txtNivel.Text = nivel;

        double notaS = Convert.ToDouble(nota);
        double examenF = Convert.ToDouble(examen);

        double final = (notaS * 0.3) + (examenF * 0.2);

        txtFinal.Text = final.ToString();
    }
}
