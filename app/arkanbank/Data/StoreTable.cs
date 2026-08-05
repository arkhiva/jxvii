using arkanbank.Models;

namespace arkanbank.Data;

public static class StoreTable {

    public static List<StoreItem> Items { get; } = [
        //------------------------------------------
        // DICAS
        //------------------------------------------

        new StoreItem {
            Id = "hint",

            Name = "Comprar Dica",

            Description = "Utilize um código para desbloquear uma dica exclusiva.",

            Category = StoreCategory.Hint,

            Price = 5,

            Quantity = 10,

            RequireApproval = false,

            Icon = "\uf0eb",

            IconFont = "IconsSolid",

            IconBackground = "#E8FAFF"
        },

        //------------------------------------------
        // EXPERIÊNCIAS
        //------------------------------------------

        new StoreItem {
            Id = "bombom",

            Name = "Caixa de Bombom",

            Description = "Receba uma caixa de bombom.",

            Category = StoreCategory.Experience,

            Price = 40,

            Quantity = 5,

            RequireApproval = true,

            Emoji = "🍫",

            IconBackground = "#FFF2F4"
        },

        new StoreItem {
            Id = "pizza",

            Name = "Pizza",

            Description = "Troque seus Nexos por uma pizza.",

            Category = StoreCategory.Experience,

            Price = 120,

            Quantity = 2,

            RequireApproval = true,

            Emoji = "🍕",

            IconBackground = "#FFF5E5"
        },

        new StoreItem {
            Id = "trip",

            Name = "Passeio",

            Description = "Uma experiência especial.",

            Category = StoreCategory.Experience,

            Price = 300,

            Quantity = 1,

            RequireApproval = true,

            Emoji = "🎡",

            IconBackground = "#EEF8FF"
        },

        //------------------------------------------
        // FUNCIONALIDADES
        //------------------------------------------

        new StoreItem {
            Id = "spinner",

            Name = "Finger Spinner",

            Description = "Desbloqueia um minigame permanente.",

            Category = StoreCategory.Feature,

            Price = 80,

            Quantity = 1,

            Purchased = false,

            RequireApproval = false,

            Icon = "\uf863",

            IconFont = "IconsSolid",

            IconBackground = "#EEF8FF"
        }
    ];
}