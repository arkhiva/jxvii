using System.Windows.Input;

namespace arkanbank.Models;

public class StoreItem {
    public string Id { get; init; } = string.Empty;

    public string Name { get; init; } = string.Empty;

    public string Description { get; init; } = string.Empty;

    public StoreCategory Category { get; init; }

    public int Price { get; init; }

    public int Quantity { get; set; }

    public bool RequireApproval { get; init; }

    public bool Purchased { get; set; }

    public string Emoji { get; init; } = string.Empty;

    public string Icon { get; init; } = string.Empty;

    public string IconFont { get; init; } = string.Empty;

    public string IconBackground { get; init; } = "#EEF8FF";

    public ICommand? BuyCommand { get; set; }

    public bool HasEmoji => !string.IsNullOrWhiteSpace(Emoji);

    public bool HasIcon => !string.IsNullOrWhiteSpace(Icon);

    public string PriceLabel => $"N$ {Price}";

    public string QuantityLabel =>
        Quantity == 1
            ? "1 disponível"
            : $"{Quantity} disponíveis";

    public bool CanBuy =>
        Quantity > 0 &&
        !Purchased;

    public string ButtonText =>
        CanBuy
            ? "Comprar"
            : "Indisponível";

    public string CategoryName => Category switch {
        StoreCategory.Hint => "DICA",
        StoreCategory.Experience => "EXPERIÊNCIA",
        StoreCategory.Feature => "FUNCIONALIDADE",
        _ => ""
    };

    public string CategoryColor => Category switch {
        StoreCategory.Hint => "#00B8D9",
        StoreCategory.Experience => "#FF8A00",
        StoreCategory.Feature => "#7B61FF",
        _ => "#999999"
    };
}

public enum StoreCategory {
    Hint,
    Experience,
    Feature
}