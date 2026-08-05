using arkanbank.Data;
using arkanbank.Models;
using arkanbank.Security;
using ZXing.Net.Maui;

namespace arkanbank.Views;

[QueryProperty(nameof(ExperienceId), nameof(ExperienceId))]
public partial class StoreExperiencePage : ContentPage {
    public string ExperienceId { get; set; } = "";

    private StoreItem product = null!;

    private bool isProcessing;
    private bool balanceVisible;
    private bool scannerRunning;

    private const string BalanceVisibilityKey = "balance_visibility";

    public StoreExperiencePage() {
        InitializeComponent();
    }

    protected override void OnAppearing() {
        base.OnAppearing();

        product = StoreTable.Items[ExperienceId];

        NameLabel.Text = product.Name;
        DescriptionLabel.Text = product.Description;
        EmojiLabel.Text = product.Emoji;

        IconBackgroundBorder.BackgroundColor =
            Color.FromArgb(product.IconBackground);

        BuyButton.Text = $"Comprar por N$ {product.Price}";

        balanceVisible = Preferences.Get(
            BalanceVisibilityKey,
            true);

        UpdateBalanceDisplay();
    }

    protected override void OnDisappearing() {
        base.OnDisappearing();

        CameraView.IsDetecting = false;
    }

    private void OnVisibility_Clicked(
        object sender,
        EventArgs e) {
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
            if(App.Wallet.Wallet.Balance < product.Price) {
                await DisplayAlertAsync(
                    "Saldo insuficiente",
                    $"Você precisa de N$ {product.Price} para comprar esta experiência.",
                    "OK");

                return;
            }

            bool confirm =
                await DisplayAlertAsync(
                    "Confirmar compra",
                    $"Deseja solicitar \"{product.Name}\" por\nN$ {product.Price}?",
                    "Continuar",
                    "Cancelar");

            if(!confirm)
                return;

            ScannerPopup.IsVisible = true;

            scannerRunning = true;
            CameraView.IsDetecting = true;
        } finally {
            isProcessing = false;
        }
    }

    private void CancelScanner_Clicked(
        object sender,
        EventArgs e) {
        scannerRunning = false;

        CameraView.IsDetecting = false;

        ScannerPopup.IsVisible = false;
    }

    private async void CameraView_BarcodesDetected(
        object sender,
        BarcodeDetectionEventArgs e) {
        if(!scannerRunning)
            return;

        scannerRunning = false;

        CameraView.IsDetecting = false;

        string encrypted =
            e.Results.First().Value;

        // Descriptografa utilizando o método já existente no projeto.
        string value = Cryptography.Decrypt(encrypted);

        if(!string.Equals(
                value,
                "kastney",
                StringComparison.OrdinalIgnoreCase)) {
            await MainThread.InvokeOnMainThreadAsync(async () => {
                ScannerPopup.IsVisible = false;

                await DisplayAlertAsync(
                    "QR Code inválido",
                    "Este QR Code não possui autorização para concluir esta compra.",
                    "OK");
            });

            return;
        }

        await MainThread.InvokeOnMainThreadAsync(async () => {
            ScannerPopup.IsVisible = false;

            App.Wallet.RemoveMoney(
                product.Price,
                $"Compra {product.Name}",
                TransactionType.Purchase);

            App.Wallet.AddInventoryItem(product.Id);

            UpdateBalanceDisplay();

            // TODO:
            // Criar solicitação pendente de aprovação.

            await DisplayAlertAsync(
                "Compra autorizada",
                $"A experiência \"{product.Name}\" foi registrada com sucesso.",
                "OK");

            await Navigation.PopAsync();
        });
    }
}