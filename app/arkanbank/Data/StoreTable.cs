using arkanbank.Models;

namespace arkanbank.Data;

public static class StoreTable {

    public static readonly IReadOnlyDictionary<string, StoreItem> Items =
        new Dictionary<string, StoreItem>(StringComparer.OrdinalIgnoreCase) {
            // ======================================================
            // DICAS
            // ======================================================

            ["hint"] = new() {
                Id = "hint",
                Name = "Comprar Dica",
                Description = "Utilize um código para desbloquear uma dica exclusiva.",
                Category = StoreCategory.Hint,
                Price = 1,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF"
            },

            // ======================================================
            // EXPERIÊNCIAS
            // ======================================================

            ["bombom"] = new() {
                Id = "bombom",
                Name = "Caixa de Bombom",
                Description = "Receba uma caixa de bombom.",
                Category = StoreCategory.Experience,
                Price = 1,
                Emoji = "🍫",
                IconBackground = "#FFF2F4"
            },

            ["pizza"] = new() {
                Id = "pizza",
                Name = "Pizza",
                Description = "Troque seus Nexos por uma pizza.",
                Category = StoreCategory.Experience,
                Price = 1,
                Emoji = "🍕",
                IconBackground = "#FFF5E5"
            },

            ["trip"] = new() {
                Id = "trip",
                Name = "Passeio",
                Description = "Uma experiência especial.",
                Category = StoreCategory.Experience,
                Price = 1,
                Emoji = "🎡",
                IconBackground = "#EEF8FF"
            },

            // ======================================================
            // FUNCIONALIDADES
            // ======================================================

            ["spinner"] = new() {
                Id = "spinner",
                Name = "Finger Spinner",
                Description = "Desbloqueia um minigame permanente.",
                Category = StoreCategory.Feature,
                Price = 1,
                Icon = "\uf863",
                IconBackground = "#EEF8FF"
            }
        };
}