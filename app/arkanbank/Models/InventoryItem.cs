namespace arkanbank.Models;

public class InventoryItem {
    public string Id { get; set; }

    public string Emoji { get; init; }
    public string Icon { get; init; }
    public string IconBackground { get; init; }

    public InventoryCategory Category { get; init; }

    public string Name { get; init; }
    public string Description { get; init; }
}