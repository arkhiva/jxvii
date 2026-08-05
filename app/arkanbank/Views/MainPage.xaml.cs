using arkanbank.Security;

namespace arkanbank.Views;

public partial class MainPage : ContentPage {
    private bool balanceVisible;
    private bool isRunning = false;

    private const string BalanceVisibilityKey = "balance_visibility";

    public MainPage() {
        InitializeComponent();
        LoadBalanceVisibility();
        //var a = Cryptography.Encrypt("kastney");
    }

    protected override void OnAppearing() {
        base.OnAppearing();

        balanceVisible = Preferences.Get(BalanceVisibilityKey, true);

        UpdateBalanceDisplay();
    }

    private void LoadBalanceVisibility() {
        balanceVisible = Preferences.Get(BalanceVisibilityKey, true);
        UpdateBalanceDisplay();
    }

    private void OnVisibility_Clicked(object sender, EventArgs e) {
        balanceVisible = !balanceVisible;
        Preferences.Set(BalanceVisibilityKey, balanceVisible);
        UpdateBalanceDisplay();
    }

    private void UpdateBalanceDisplay() {
        if(!balanceVisible) {
            BalanceLabel.Text = "••••••••";
            BalanceCentLabel.Text = "";
            VisibilityButton.Text = "\uf070";
            return;
        }

        BalanceLabel.Text = $"{App.Wallet.Wallet.Balance}";
        BalanceCentLabel.Text = ",00";
        VisibilityButton.Text = "\uf06e";
    }

    private async void ScanTapped(object sender, TappedEventArgs e) {
        if(isRunning) { return; }
        isRunning = true;
        await Shell.Current.GoToAsync(nameof(ScanPage));
        isRunning = false;
    }

    private async void ExtractTapped(object sender, TappedEventArgs e) {
        if(isRunning) { return; }
        isRunning = true;
        await Shell.Current.GoToAsync(nameof(TransactionsPage));
        isRunning = false;
    }

    private async void StoreTapped(object sender, TappedEventArgs e) {
        if(isRunning) { return; }
        isRunning = true;
        await Shell.Current.GoToAsync(nameof(StorePage));
        isRunning = false;
    }

    private async void InventoryTapped(object sender, TappedEventArgs e) {
        if(isRunning) { return; }
        isRunning = true;
        await Shell.Current.GoToAsync(nameof(InventoryPage));
        isRunning = false;
    }
}