namespace DoubleTapError.App;

public partial class FirstPage : ContentPage
{
    public FirstPage() => InitializeComponent();

    private async void OnGesture(object sender, EventArgs e)
    {
        Navigation.InsertPageBefore(new SecondPage(), this);
        await Navigation.PopAsync(animated: false);
    }
}