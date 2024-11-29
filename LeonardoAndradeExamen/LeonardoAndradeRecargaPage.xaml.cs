using System;
using System.IO;
using Microsoft.Maui.Controls;

namespace LeonardoAndradeExamen
{
    public partial class LeonardoAndradeRecargaPage : ContentPage
    {
        public LeonardoAndradeRecargaPage()
        {
            InitializeComponent();
        }

        private async void OnRecargarClicked(object sender, EventArgs e)
        {
            // Obtener los datos ingresados
            string phoneNumber = PhoneNumberEntry.Text?.Trim();
            string clientName = ClientNameEntry.Text?.Trim();

            // Validar los datos
            if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(clientName))
            {
                await DisplayAlert("Error", "Por favor, complete todos los campos.", "Aceptard");
                return;
            }

            // Construir el contenido para guardar
            string content = $"Cliente: {clientName}\nTeléfono: {phoneNumber}\nFecha: {DateTime.Now}\n";

            // Obtener la ruta para guardar el archivo
            string fileName = "recarga.txt";
            string filePath = Path.Combine(FileSystem.AppDataDirectory, fileName);

            // Guardar el contenido en el archivo
            File.WriteAllText(filePath, content);

            
            
            await DisplayAlert("True", $"Se ha guardado la recarga en: {filePath}", "Aceptar");
        }

    }
}

