namespace VibeCircle.Pages;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PostDetailsPage), animate: true);
    }

    private async void AddPost_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddPostPage), animate: true);
    }
    private async void GoToProfilePage_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddPostPage), animate: true);
    }
}