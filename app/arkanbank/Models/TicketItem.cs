namespace arkanbank.Models;

public class TicketItem {
    public string Id { get; set; }

    public int Level { get; init; }
    public int Value { get; init; }

    public string Name { get; set; }

    public TransactionType Type { get; set; }
}