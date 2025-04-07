namespace VibeCircle.Pages;

public partial class NotificationPage : ContentPage
{
    public NotificationPage()
    {
        InitializeComponent();

        List<NotificationModel> notifications = [
            new NotificationModel(DateTime.Now, "This Person Liked your post"),
            new NotificationModel(DateTime.Now.AddDays(-5), "This Person commented on your post"),
            new NotificationModel(DateTime.Now.AddMinutes(50), "This Person bookmarked your post"),
        ];
        collection.ItemsSource = notifications;
    }

    public record NotificationModel(DateTime On, string Text);
}