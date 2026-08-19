using arkanbank.Data;
using arkanbank.Models;
using System.Collections.ObjectModel;

namespace arkanbank.Views;

public partial class StorePage : ContentPage {
    private bool balanceVisible;
    private bool isRunning = false;

    private const string BalanceVisibilityKey = "balance_visibility";

    public ObservableCollection<StoreItem> Products { get; } = [];

    public StorePage() {
        InitializeComponent();

        BindingContext = this;
    }

    protected override void OnAppearing() {
        base.OnAppearing();

        balanceVisible = Preferences.Get(
            BalanceVisibilityKey,
            true);

        Refresh();
    }

    private void Refresh() {
        Products.Clear();

        foreach(StoreItem item in StoreTable.Items.Values) {
            Products.Add(item);
        }

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

    private async void StoreCell_Clicked(object sender, EventArgs e) {
        if(sender is not Controls.Cells.StoreCell cell)
            return;

        if(isRunning) { return; }
        isRunning = true;
        switch(cell.Id) {
            case "hint": {
                // Abri a página de compra de dica!
                await Shell.Current.GoToAsync(nameof(StoreHintPage));
                break;
            }
            case "spinner": {
                // Abri a página de compra de uma funcionalidade!
                await Shell.Current.GoToAsync($"{nameof(StoreFeaturePage)}?FeatureId={cell.Id}");
                break;
            }
            default: {
                // Abri a página de compra de uma experiência!
                await Shell.Current.GoToAsync($"{nameof(StoreExperiencePage)}?ExperienceId={cell.Id}");
                break;
            }
        }
        isRunning = false;
    }
}