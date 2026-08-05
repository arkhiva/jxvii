namespace arkanbank.Models;

public class StoreItem {
    public string Id { get; init; } = string.Empty;

    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;

    public StoreCategory Category { get; init; }

    public string Emoji { get; init; } = string.Empty;
    public string Icon { get; init; } = string.Empty;
    public string IconBackground { get; init; }

    public int Price { get; init; }
}