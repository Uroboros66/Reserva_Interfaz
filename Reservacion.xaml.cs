namespace Reserva_Interfaz;

public partial class Reservacion : ContentPage
{
	public Reservacion()
	{
		InitializeComponent();
        fechaPicker.MinimumDate = DateTime.Now;  // Establecer fecha m�nima en c�digo subyacente
    }
}