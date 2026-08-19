namespace arkanbank.Views;

public partial class FidgetSpinnerPage : ContentPage {

    public FidgetSpinnerPage() {
        InitializeComponent();
        LoadSpinner();
    }

    private async void LoadSpinner() {
        using Stream stream = await FileSystem.OpenAppPackageFileAsync("fidget_spinner.html");
        using StreamReader reader = new(stream);
        string html = await reader.ReadToEndAsync();
        SpinnerWebView.Source = new HtmlWebViewSource {
            Html = html
        };
    }
}