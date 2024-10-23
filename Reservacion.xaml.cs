namespace Reserva_Interfaz;

public partial class Reservacion : ContentPage
{
	public Reservacion()
	{
		InitializeComponent();
        fechaPicker.MinimumDate = DateTime.Now;  // Establecer fecha mínima en código subyacente
    }
}