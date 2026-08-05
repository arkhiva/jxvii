using arkanbank.Data;
using arkanbank.Models;

namespace arkanbank.Views;

[QueryProperty(nameof(FeatureId), nameof(FeatureId))]
public partial class StoreFeaturePage : ContentPage {
    public string FeatureId { get; set; } = string.Empty;

    private StoreItem product = null!;

    private bool balanceVisible;
    private bool isProcessing;

    private const string BalanceVisibilityKey = "balance_visibility";

    public StoreFeaturePage() {
        InitializeComponent();
    }

    protected override void OnAppearing() {
        base.OnAppearing();

        balanceVisible = Preferences.Get(
            BalanceVisibilityKey,
            true);

        product = StoreTable.Items[FeatureId];

        Refresh();
    }

    private void Refresh() {
        UpdateBalanceDisplay();

        NameLabel.Text = product.Name;

        DescriptionLabel.Text = product.Description;

        BuyButton.Text = $"Comprar por N$ {product.Price:N0}";

        IconBackgroundBorder.BackgroundColor =
            Color.FromArgb(product.IconBackground);

        if(!string.IsNullOrWhiteSpace(product.Icon)) {
            IconLabel.Text = product.Icon;
            IconLabel.FontFamily = "IconsSolid";

            IconLabel.IsVisible = true;
            EmojiLabel.IsVisible = false;
        } else {
            EmojiLabel.Text = product.Emoji;

            EmojiLabel.IsVisible = true;
            IconLabel.IsVisible = false;
        }
    }

    private void OnVisibility_Clicked(object sender, EventArgs e) {
        balanceVisible = !balanceVisible;

        Preferences.Set(
            BalanceVisibilityKey,
            balanceVisible);

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
            App.Wallet.Wallet.Balance.ToString("N0");

        BalanceCentLabel.Text = ",00";

        VisibilityButton.Text = "\uf06e";
    }

    private async void BuyButton_Clicked(
        object sender,
        EventArgs e) {
        if(isProcessing)
            return;

        isProcessing = true;

        try {
            if(App.Wallet.HasInventoryItem(product.Id)) {
                await DisplayAlertAsync(
                    "Já adquirida",
                    "Você já possui esta funcionalidade.",
                    "OK");

                return;
            }

            if(App.Wallet.Wallet.Balance < product.Price) {
                await DisplayAlertAsync(
                    "Saldo insuficiente",
                    $"Você precisa de N$ {product.Price} para realizar esta compra.",
                    "OK");

                return;
            }

            bool confirm =
                await DisplayAlertAsync(
                    "Confirmar compra",
                    $"Deseja desbloquear \"{product.Name}\" por\nN$ {product.Price}?",
                    "Comprar",
                    "Cancelar");

            if(!confirm)
                return;

            App.Wallet.RemoveMoney(
                product.Price,
                $"Compra {product.Name}",
                TransactionType.Purchase);

            App.Wallet.AddInventoryItem(product.Id);

            UpdateBalanceDisplay();

            await DisplayAlertAsync(
                "Compra realizada",
                $"{product.Name} foi desbloqueada com sucesso.",
                "OK");

            await Navigation.PopAsync();
        } finally {
            isProcessing = false;
        }
    }
}