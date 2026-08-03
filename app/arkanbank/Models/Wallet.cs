namespace arkanbank.Models;

public class Wallet {
    public int Balance { get; set; }

    public List<Transaction> Transactions { get; set; } = [];

    public List<InventoryItem> Inventory { get; set; } = [];
}