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
            await DisplayAlert("Éxito", "Recarga realizada correctamente.", "OK");
        }
    }
}
