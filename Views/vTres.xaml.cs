namespace fushcasinaRepasoA.Views;

public partial class vTres : ContentPage
{
	public vTres()
	{
		InitializeComponent(String Desarrolllo, String asignatura, string nivel, string examen, string nota)
		txtDesarrollado.Text = Desarrollo;
		txtAsignatura.Text = Asignatura;
		txtNivel.Text = nivel;
		double.notaS = Convert.ToDouble(nota);
		double examenF = Convert.ToDouble(examen);
		double final = (NotActiveExceptionS * 0.3) + (examenF * 0.2);
		txtFinal.Text = final.ToString;
	}
}