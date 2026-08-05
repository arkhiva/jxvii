using arkanbank.Data;
using arkanbank.Models;
using System.Text.Json;

namespace arkanbank.Services;

public class WalletService {
    private readonly string filePath;

    public Wallet Wallet { get; private set; }

    public WalletService() {
        filePath = Path.Combine(
            FileSystem.AppDataDirectory,
            "wallet.json");

        Load();
    }

    public void Load() {
        if(File.Exists(filePath)) {
            string json = File.ReadAllText(filePath);
            Wallet = JsonSerializer.Deserialize<Wallet>(json) ?? new Wallet();
            //ClearData();
        } else {
            Wallet = new Wallet();
            Save();
        }
    }

    public void Save() {
        string json =
            JsonSerializer.Serialize(
                Wallet,
                new JsonSerializerOptions {
                    WriteIndented = true
                });

        File.WriteAllText(
            filePath,
            json);
    }

    #region Money

    public void AddMoney(
        int amount,
        string title,
        TransactionType type = TransactionType.Reward) {
        Wallet.Balance += amount;

        Wallet.Transactions.Insert(
            0,
            new Transaction {
                Title = title,
                Amount = amount,
                Date = DateTime.Now,
                Type = type
            });

        Save();
    }

    public void RemoveMoney(
        int amount,
        string title,
        TransactionType type = TransactionType.Purchase) {
        Wallet.Balance -= amount;

        Wallet.Transactions.Insert(
            0,
            new Transaction {
                Title = title,
                Amount = -amount,
                Date = DateTime.Now,
                Type = type
            });

        Save();
    }

    #endregion Money

    #region Inventory

    public IReadOnlyCollection<string> Inventory
        => Wallet.Inventory;

    public void AddInventoryItem(string id) {
        Wallet.Inventory.Add(id);

        Save();
    }

    public bool HasInventoryItem(string id) {
        return Wallet.Inventory.Contains(id);
    }

    public InventoryItem? GetInventoryItem(string id) {
        if(!Wallet.Inventory.Contains(id))
            return null;

        return InventoryTable.Items.TryGetValue(
            id,
            out InventoryItem? item)
                ? item
                : null;
    }

    public void RemoveInventoryItem(string id) {
        if(Wallet.Inventory.Remove(id))
            Save();
    }

    public void ClearInventory() {
        Wallet.Inventory.Clear();

        Save();
    }

    #endregion Inventory

    #region Rewards

    public bool IsRewardRedeemed(string ticket) {
        return Wallet.RedeemedRewards.Contains(ticket);
    }

    public void RegisterReward(string ticket) {
        Wallet.RedeemedRewards.Add(ticket);

        Save();
    }

    #endregion Rewards

    #region Debug

    public void ClearData() {
        Wallet = new Wallet();

        Save();
    }

    #endregion Debug
}