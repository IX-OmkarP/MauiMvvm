using MauiMvvm.ViewModels;
using System.Windows.Input;

namespace MauiMvvm.Views;

public partial class MainPage : ContentPage
{
    MainPageViewModel ViewModel { get; }
    public ICommand TakePhotoCommand { get; }
    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        ViewModel = (MainPageViewModel)BindingContext;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        //TakePhotoCommand = new Command(TakePhotoByCameraAsync);
    }
}