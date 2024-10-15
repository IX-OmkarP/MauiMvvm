using MauiMvvm.ViewModels;
namespace MauiMvvm.Views;

public partial class MainPage : ContentPage
{
    MainPageViewModel ViewModel { get; }
    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        ViewModel = viewModel;
        BindingContext = ViewModel;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        ViewModel.TakePhotoAsync();
    }
}