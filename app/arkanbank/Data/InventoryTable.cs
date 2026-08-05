using arkanbank.Models;

namespace arkanbank.Data;

public static class InventoryTable {

    public static readonly IReadOnlyDictionary<string, InventoryItem> Items =
        new Dictionary<string, InventoryItem>(StringComparer.OrdinalIgnoreCase) {
            ["JXVII-IVTY-0001"] = new() { Id = "JXVII-IVTY-0001", Name = "Dica do Nível 1", Description = "Uma dica para o nível 1", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0002"] = new() { Id = "JXVII-IVTY-0002", Name = "Dica do Nível 2", Description = "Uma dica para o nível 2", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0003"] = new() { Id = "JXVII-IVTY-0003", Name = "Dica do Nível 3", Description = "Uma dica para o nível 3", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0004"] = new() { Id = "JXVII-IVTY-0004", Name = "Dica do Nível 4", Description = "Uma dica para o nível 4", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0005"] = new() { Id = "JXVII-IVTY-0005", Name = "Dica do Nível 5", Description = "Uma dica para o nível 5", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0006"] = new() { Id = "JXVII-IVTY-0006", Name = "Dica do Nível 6", Description = "Uma dica para o nível 6", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0007"] = new() { Id = "JXVII-IVTY-0007", Name = "Dica do Nível 7", Description = "Uma dica para o nível 7", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0008"] = new() { Id = "JXVII-IVTY-0008", Name = "Dica do Nível 8", Description = "Uma dica para o nível 8", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0009"] = new() { Id = "JXVII-IVTY-0009", Name = "Dica do Nível 9", Description = "Uma dica para o nível 9", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0010"] = new() { Id = "JXVII-IVTY-0010", Name = "Dica do Nível 10", Description = "Uma dica para o nível 10", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0011"] = new() { Id = "JXVII-IVTY-0011", Name = "Dica do Nível 11", Description = "Uma dica para o nível 11", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0012"] = new() { Id = "JXVII-IVTY-0012", Name = "Dica do Nível 12", Description = "Uma dica para o nível 12", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0013"] = new() { Id = "JXVII-IVTY-0013", Name = "Dica do Nível 13", Description = "Uma dica para o nível 13", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0014"] = new() { Id = "JXVII-IVTY-0014", Name = "Dica do Nível 14", Description = "Uma dica para o nível 14", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0015"] = new() { Id = "JXVII-IVTY-0015", Name = "Dica do Nível 15", Description = "Uma dica para o nível 15", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0016"] = new() { Id = "JXVII-IVTY-0016", Name = "Dica do Nível 16", Description = "Uma dica para o nível 16", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0017"] = new() { Id = "JXVII-IVTY-0017", Name = "Dica do Nível 17", Description = "Uma dica para o nível 17", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0018"] = new() { Id = "JXVII-IVTY-0018", Name = "Dica do Nível 18", Description = "Uma dica para o nível 18", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0019"] = new() { Id = "JXVII-IVTY-0019", Name = "Dica do Nível 19", Description = "Uma dica para o nível 19", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0020"] = new() { Id = "JXVII-IVTY-0020", Name = "Dica do Nível 20", Description = "Uma dica para o nível 20", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0021"] = new() { Id = "JXVII-IVTY-0021", Name = "Dica do Nível 21", Description = "Uma dica para o nível 21", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0022"] = new() { Id = "JXVII-IVTY-0022", Name = "Dica do Nível 22", Description = "Uma dica para o nível 22", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0023"] = new() { Id = "JXVII-IVTY-0023", Name = "Dica do Nível 23", Description = "Uma dica para o nível 23", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0024"] = new() { Id = "JXVII-IVTY-0024", Name = "Dica do Nível 24", Description = "Uma dica para o nível 24", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0025"] = new() { Id = "JXVII-IVTY-0025", Name = "Dica do Nível 25", Description = "Uma dica para o nível 25", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0026"] = new() { Id = "JXVII-IVTY-0026", Name = "Dica do Nível 26", Description = "Uma dica para o nível 26", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0027"] = new() { Id = "JXVII-IVTY-0027", Name = "Dica do Nível 27", Description = "Uma dica para o nível 27", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0028"] = new() { Id = "JXVII-IVTY-0028", Name = "Dica do Nível 28", Description = "Uma dica para o nível 28", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0029"] = new() { Id = "JXVII-IVTY-0029", Name = "Dica do Nível 29", Description = "Uma dica para o nível 29", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0030"] = new() { Id = "JXVII-IVTY-0030", Name = "Dica do Nível 30", Description = "Uma dica para o nível 30", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0031"] = new() { Id = "JXVII-IVTY-0031", Name = "Dica do Nível 31", Description = "Uma dica para o nível 31", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0032"] = new() { Id = "JXVII-IVTY-0032", Name = "Dica do Nível 32", Description = "Uma dica para o nível 32", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0033"] = new() { Id = "JXVII-IVTY-0033", Name = "Dica do Nível 33", Description = "Uma dica para o nível 33", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0034"] = new() { Id = "JXVII-IVTY-0034", Name = "Dica do Nível 34", Description = "Uma dica para o nível 34", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0035"] = new() { Id = "JXVII-IVTY-0035", Name = "Dica do Nível 35", Description = "Uma dica para o nível 35", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0036"] = new() { Id = "JXVII-IVTY-0036", Name = "Dica do Nível 36", Description = "Uma dica para o nível 36", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0037"] = new() { Id = "JXVII-IVTY-0037", Name = "Dica do Nível 37", Description = "Uma dica para o nível 37", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0038"] = new() { Id = "JXVII-IVTY-0038", Name = "Dica do Nível 38", Description = "Uma dica para o nível 38", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0039"] = new() { Id = "JXVII-IVTY-0039", Name = "Dica do Nível 39", Description = "Uma dica para o nível 39", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0040"] = new() { Id = "JXVII-IVTY-0040", Name = "Dica do Nível 40", Description = "Uma dica para o nível 40", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0041"] = new() { Id = "JXVII-IVTY-0041", Name = "Dica do Nível 41", Description = "Uma dica para o nível 41", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0042"] = new() { Id = "JXVII-IVTY-0042", Name = "Dica do Nível 42", Description = "Uma dica para o nível 42", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
            ["JXVII-IVTY-0043"] = new() { Id = "JXVII-IVTY-0043", Name = "Dica do Nível 43", Description = "Uma dica para o nível 43", Category = InventoryCategory.Hint, Icon = "\uf0eb", IconBackground = "#E8FAFF" },
        };
}