namespace MauiApphotel.Views;

public partial class ContratacaodaHospedagem : ContentPage
{
    public ContratacaodaHospedagem()
    {
        InitializeComponent();
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}