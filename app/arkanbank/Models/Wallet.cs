namespace arkanbank.Models;

public class Wallet {
    public int Balance { get; set; }

    public List<Transaction> Transactions { get; set; } = [];

    public HashSet<string> Inventory { get; set; } = [];

    public HashSet<string> RedeemedRewards { get; set; } = [];
}