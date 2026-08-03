namespace arkanbank.Models;

public class Transaction {
    public string Id { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public DateTime Date { get; set; }

    public int Amount { get; set; }

    public TransactionType Type { get; set; } = TransactionType.System;
}