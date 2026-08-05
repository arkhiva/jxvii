using arkanbank.Data;
using arkanbank.Models;
using System.Collections.ObjectModel;

namespace arkanbank.Views;

public partial class InventoryPage : ContentPage {
    public ObservableCollection<InventoryItem> Inventory { get; } = [];

    public InventoryPage() {
        InitializeComponent();
        BindingContext = this;
    }

    protected override void OnAppearing() {
        base.OnAppearing();

        LoadInventory();
    }

    private void LoadInventory() {
        Inventory.Clear();

        foreach(string id in App.Wallet.Inventory) {
            if(InventoryTable.Items.TryGetValue(id, out InventoryItem? item)) {
                Inventory.Add(item);
            }
        }
    }

    private async void InventoryCell_Clicked(object sender, string e) {
        await DisplayAlert("Item clicado", e, "OK");
    }
}