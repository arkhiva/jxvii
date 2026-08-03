using arkanbank.Models;

namespace arkanbank.Views;

public partial class MainPage : ContentPage {
    private bool balanceVisible;
    private bool isRunning = false;

    private const string BalanceVisibilityKey = "balance_visibility";

    public MainPage() {
        InitializeComponent();

        LoadBalanceVisibility();
    }

    protected override void OnAppearing() {
        base.OnAppearing();

        UpdateBalanceDisplay();
    }

    private void LoadBalanceVisibility() {
        balanceVisible = Preferences.Get(
            BalanceVisibilityKey,
            true
        );

        UpdateBalanceDisplay();
    }

    private void OnVisibility_Clicked(object sender, EventArgs e) {
        balanceVisible = !balanceVisible;

        Preferences.Set(
            BalanceVisibilityKey,
            balanceVisible
        );

        UpdateBalanceDisplay();
    }

    private void UpdateBalanceDisplay() {
        if(!balanceVisible) {
            BalanceLabel.Text = "••••••••";
            BalanceCentLabel.Text = "";

            VisibilityButton.Text = "\uf070";

            return;
        }

        BalanceLabel.Text =
            $"{App.Wallet.Wallet.Balance}";

        BalanceCentLabel.Text =
            ",00";

        VisibilityButton.Text =
            "\uf06e";
    }

    private void ScanTapped(object sender, TappedEventArgs e) {
        App.Wallet.AddMoney(
            20,
            "QR Code",
            TransactionType.Reward
        );

        UpdateBalanceDisplay();
    }

    private async void ExtractTapped(object sender, TappedEventArgs e) {
        if(isRunning)
            return;

        isRunning = true;

        await Shell.Current.GoToAsync(
            nameof(TransactionsPage)
        );

        isRunning = false;
    }

    private void StoreTapped(object sender, TappedEventArgs e) {
        App.Wallet.RemoveMoney(
            5,
            "Compra da dica",
            TransactionType.Purchase
        );

        UpdateBalanceDisplay();
    }

    private void InventoryTapped(object sender, TappedEventArgs e) {
        // Temporário apenas para testes
        App.Wallet.ClearData();

        UpdateBalanceDisplay();
    }
}