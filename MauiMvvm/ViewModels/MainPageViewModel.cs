namespace MauiMvvm.ViewModels;

public class MainPageViewModel : ViewModelBase
{
    private string _photoPath;
    public string PhotoPath
    {
        get => _photoPath;
        set => SetProperty(ref _photoPath, value);
    }

    public MainPageViewModel()
    {
        // TakePhotoCommand = new AsyncRelayCommand(TakePhotoAsync);
    }

    public async Task TakePhotoAsync()
    {
        try
        {
            var photo = await MediaPicker.CapturePhotoAsync();
            using var stream = await photo.OpenReadAsync();
            var streamImageSource = ImageSource.FromStream(() => stream);
            PhotoPath = streamImageSource.ToString(); // or handle as needed
        }
        catch (Exception ex)
        {
            // Handle exceptions
            await App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
        }
    }
}
