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
            await DisplayAlert("�xitoo", "Recarga realizada correctamente.", "TRUE");
        }
    }
}
