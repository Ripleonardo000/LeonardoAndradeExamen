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
            await DisplayAlert("Éxitoo", "Recarga realizada correctamente.", "TRUE");
        }
    }
}
