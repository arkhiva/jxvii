using arkanbank.Data;
using arkanbank.Models;
using System.Collections.ObjectModel;

namespace arkanbank.Views;

public partial class StorePage : ContentPage {
    private bool balanceVisible;

    private const string BalanceVisibilityKey = "balance_visibility";

    public ObservableCollection<StoreItem> Products { get; } = new();

    public StorePage() {
        InitializeComponent();

        BindingContext = this;

        foreach(var item in StoreTable.Items) {
            item.BuyCommand = new Command(async () => await Buy(item));

            Products.Add(item);
        }
    }

    protected override void OnAppearing() {
        base.OnAppearing();

        balanceVisible = Preferences.Get(BalanceVisibilityKey, true);

        UpdateBalanceDisplay();
    }

    private async Task Buy(StoreItem item) {
        if(App.Wallet.Wallet.Balance < item.Price) {
            await DisplayAlert(
                "Saldo insuficiente",
                "Você não possui Nexos suficientes.",
                "OK");

            return;
        }

        if(item.RequireApproval) {
            await DisplayAlert(
                "Aprovação",
                "Essa compra requer aprovação por QR Code.",
                "Continuar");

            // TODO:
            // abrir tela de aprovação.
            return;
        }

        App.Wallet.RemoveMoney(
            item.Price,
            $"Compra: {item.Name}",
            TransactionType.Purchase);

        //App.Wallet.AddInventoryItem(new InventoryItem {Name = "Dica Nível 3", Description = "", });

        item.Quantity--;

        if(item.Category == StoreCategory.Feature)
            item.Purchased = true;

        BalanceLabel.Text = App.Wallet.Wallet.Balance.ToString();

        Refresh();
    }

    private void Refresh() {
        Products.Clear();

        foreach(var item in StoreTable.Items) {
            if(item.Category == StoreCategory.Feature && item.Purchased)
                continue;

            if(item.Quantity == 0)
                continue;

            Products.Add(item);
        }
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
}