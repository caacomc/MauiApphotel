namespace MauiApphotel.Views;

public partial class ContratacaodaHospedagem : ContentPage
{
    App PropriedadesApp;

    public ContratacaodaHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;
        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);

        // ✅ Conversão segura de DateTime? para DateTime
        DateTime checkinDate = dtpck_checkin.Date.GetValueOrDefault(DateTime.Now);

        dtpck_checkout.MinimumDate = checkinDate.AddDays(1);
        dtpck_checkout.MaximumDate = checkinDate.AddMonths(6);

        dtpck_checkin.DateSelected += Dtpck_checkin_DateSelected;
    }

    private void Dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DateTime newDate = (DateTime)e.NewDate;
        dtpck_checkout.MinimumDate = newDate.AddDays(1);
        dtpck_checkout.MaximumDate = newDate.AddMonths(6);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}
