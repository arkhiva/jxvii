using System.Text.Json;
using arkanbank.Models;

namespace arkanbank.Services;

public class WalletService {
    private readonly string filePath;

    public Wallet Wallet { get; private set; }

    public WalletService() {
        filePath = Path.Combine(
            FileSystem.AppDataDirectory,
            "wallet.json"
        );

        Load();
    }

    public void Load() {
        if(File.Exists(filePath)) {
            string json = File.ReadAllText(filePath);

            Wallet =
                JsonSerializer.Deserialize<Wallet>(json)
                ?? new Wallet();
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
            json
        );
    }

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

    public void AddInventoryItem(string name) {
        Wallet.Inventory.Add(

            new InventoryItem {
                Name = name,

                PurchaseDate = DateTime.Now
            });

        Save();
    }

    public void ClearData() {
        Wallet = new Wallet();

        Save();
    }
}