namespace MauiMvvm.ViewModels;

public class MainPageViewModel : ViewModelBase
{
    public MainPageViewModel() { }

    public async Task TakePhotoAsync()
    {
        try
        {
            await App.Current.MainPage.DisplayAlert("Display Alert", "Before camera", "Ok");
            var photo = await MediaPicker.CapturePhotoAsync();
            await App.Current.MainPage.DisplayAlert("Display Alert", "After camera","Ok");
        }
        catch (Exception ex)
        {
            await App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
        }
    }
}
