using ExamenHansOrtiz.Models;
using ExamenHansOrtiz.Services;
using ExamenHansOrtiz.ViewModels;

namespace ExamenHansOrtiz.Views;

public partial class HO_CalleDetailPage : ContentPage
{
    public HO_CalleDetailPage(HO_Calle calleSeleccionada)
    {
        InitializeComponent();

        var viewModel = new HO_CalledetailViewModel(App.Current.Handler.MauiContext.Services.GetService<HO_DatabaseService>());
        viewModel.CalleSeleccionada = calleSeleccionada;
        BindingContext = viewModel;
    }
}