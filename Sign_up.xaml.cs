namespace Reserva_Interfaz;

public partial class Sign_up : ContentPage
{
	public Sign_up()
	{
		InitializeComponent();
	}

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        await saveButton.ScaleTo(1.2, 100);

        // Vuelve el botón a su tamaño original
        await saveButton.ScaleTo(1.0, 100);
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Navegar de regreso a la página de inicio de sesión
        await Navigation.PopAsync();
    }

    private void OnRoleSelected(object sender, EventArgs e)
    {
        var picker = sender as Picker;
        if (picker != null)
        {
            // Obtén el rol seleccionado
            string selectedRole = picker.SelectedItem.ToString();

            // Aquí puedes agregar la lógica que deseas ejecutar al seleccionar un rol
            // Por ejemplo, podrías mostrar un mensaje o navegar a otra página
            Console.WriteLine($"Rol seleccionado: {selectedRole}");
        }
    }
}