using arkanbank.Data;
using arkanbank.Models;

namespace arkanbank.Views;

public partial class StoreHintPage : ContentPage {
    private readonly StoreItem hintProduct;

    private bool isProcessing;
    private bool balanceVisible;

    private const string BalanceVisibilityKey = "balance_visibility";

    public StoreHintPage() {
        InitializeComponent();

        hintProduct = StoreTable.Items["hint"];

        button.Text = $"Comprar por N$ {hintProduct.Price}";
    }

    protected override void OnAppearing() {
        base.OnAppearing();

        balanceVisible = Preferences.Get(
            BalanceVisibilityKey,
            true);

        UpdateBalanceDisplay();
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
            if(App.Wallet.Wallet.Balance < hintProduct.Price) {
                await DisplayAlertAsync(
                    "Saldo insuficiente",
                    $"Você precisa de N$ {hintProduct.Price} para comprar uma dica.",
                    "OK");

                return;
            }

            string reference =
                ReferenceEntry.Text?.Trim() ?? string.Empty;

            if(reference.Length != 5) {
                await DisplayAlertAsync(
                    "Código inválido",
                    "Informe um código da fase com 5 dígitos.",
                    "OK");

                return;
            }

            InventoryItem? item =
                InventoryTable.Items.Values
                    .FirstOrDefault(x => x.Reference == reference);

            if(item is null) {
                await DisplayAlertAsync(
                    "Código inválido",
                    "Nenhuma dica foi encontrada para este código.",
                    "OK");

                return;
            }

            if(App.Wallet.HasInventoryItem(item.Id)) {
                await DisplayAlertAsync(
                    "Já adquirida",
                    "Você já comprou esta dica.",
                    "OK");

                return;
            }

            bool confirm =
                await DisplayAlertAsync(
                    "Confirmar compra",
                    $"Deseja comprar \"{item.Name}\" por N$ {hintProduct.Price}?",
                    "Comprar",
                    "Cancelar");

            if(!confirm)
                return;

            App.Wallet.RemoveMoney(
                hintProduct.Price,
                $"Compra {item.Name}",
                TransactionType.Purchase);

            App.Wallet.AddInventoryItem(item.Id);

            UpdateBalanceDisplay();

            await DisplayAlertAsync(
                "Compra realizada",
                $"{item.Name} foi adicionada ao seu inventário.",
                "OK");

            await Navigation.PopAsync();
        } finally {
            isProcessing = false;
        }
    }
}