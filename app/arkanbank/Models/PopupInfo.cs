namespace arkanbank.Models;

public sealed class PopupInfo {
    public string Title { get; init; } = "";

    public string Description { get; init; } = "";

    public string Value { get; init; } = "";

    public string Icon { get; init; } = "";

    public Color Color { get; init; } = Colors.Green;
}