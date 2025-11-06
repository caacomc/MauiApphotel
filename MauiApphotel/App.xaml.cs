using MauiApphotel.Models;
using MauiApphotel.Views;

namespace MauiApphotel;

public partial class App : Application
{
    public List<Quarto> lista_quartos = new List<Quarto>
    {
        new Quarto ()
        {
            Descricao = "Suíte Super Luxo",
           ValorDiariaAdulto = 150.0,
           ValorDiariaCrianca = 75.0,
        },

        new Quarto ()
        {
            Descricao = "Suíte Luxo",
           ValorDiariaAdulto = 100.0,
           ValorDiariaCrianca = 50.0,
        },
        new Quarto ()
        {
            Descricao = "Suíte Standard",
           ValorDiariaAdulto = 50.0,
           ValorDiariaCrianca = 40.0,
        },
        new Quarto ()
        {
            Descricao = "Suíte Single",
           ValorDiariaAdulto = 30.0,
           ValorDiariaCrianca = 15.0,
        }

    };

    [Obsolete]
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new ContratacaodaHospedagem());
    }
    protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = base.CreateWindow(activationState);

        window.Width = 400;
        window.Height = 600;

        return window;
    }
}