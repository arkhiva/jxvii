using arkanbank.Models;

namespace arkanbank.Data;

public static class TicketTable {

    public static readonly IReadOnlyDictionary<string, TicketItem> Items =
        new Dictionary<string, TicketItem>(StringComparer.OrdinalIgnoreCase) {
            ["JXVII-4D9A-81BC"] = new() { Id = "JXVII-4D9A-81BC", Level = 01, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-8F2K-91LM"] = new() { Id = "JXVII-8F2K-91LM", Level = 02, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-3H7K-82PQ"] = new() { Id = "JXVII-3H7K-82PQ", Level = 03, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-7L4M-15QX"] = new() { Id = "JXVII-7L4M-15QX", Level = 04, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-9R2B-47NV"] = new() { Id = "JXVII-9R2B-47NV", Level = 05, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-6C8Y-32FH"] = new() { Id = "JXVII-6C8Y-32FH", Level = 06, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-2J6D-84TK"] = new() { Id = "JXVII-2J6D-84TK", Level = 07, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-5N9A-61RE"] = new() { Id = "JXVII-5N9A-61RE", Level = 08, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-8M3P-72GW"] = new() { Id = "JXVII-8M3P-72GW", Level = 09, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-1H5X-93LV"] = new() { Id = "JXVII-1H5X-93LV", Level = 10, Type = TransactionType.Reward, Value = 1 },

            ["JXVII-4Q8F-16KB"] = new() { Id = "JXVII-4Q8F-16KB", Level = 11, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-7Y1N-35CP"] = new() { Id = "JXVII-7Y1N-35CP", Level = 12, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-2V7J-58MD"] = new() { Id = "JXVII-2V7J-58MD", Level = 13, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-6T4L-27FN"] = new() { Id = "JXVII-6T4L-27FN", Level = 14, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-5B2R-79QJ"] = new() { Id = "JXVII-5B2R-79QJ", Level = 15, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-8D6P-43XM"] = new() { Id = "JXVII-8D6P-43XM", Level = 16, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-9A1V-54LC"] = new() { Id = "JXVII-9A1V-54LC", Level = 17, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-3K8M-28YD"] = new() { Id = "JXVII-3K8M-28YD", Level = 18, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-1P4T-95NB"] = new() { Id = "JXVII-1P4T-95NB", Level = 19, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-6R3F-71QH"] = new() { Id = "JXVII-6R3F-71QH", Level = 20, Type = TransactionType.Reward, Value = 1 },

            ["JXVII-4N9C-62XA"] = new() { Id = "JXVII-4N9C-62XA", Level = 21, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-7F5V-18MR"] = new() { Id = "JXVII-7F5V-18MR", Level = 22, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-2C7L-84YP"] = new() { Id = "JXVII-2C7L-84YP", Level = 23, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-5M8H-36VD"] = new() { Id = "JXVII-5M8H-36VD", Level = 24, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-8X1P-53JF"] = new() { Id = "JXVII-8X1P-53JF", Level = 25, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-9L6N-24BK"] = new() { Id = "JXVII-9L6N-24BK", Level = 26, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-3P5X-87MC"] = new() { Id = "JXVII-3P5X-87MC", Level = 27, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-1D9R-45YN"] = new() { Id = "JXVII-1D9R-45YN", Level = 28, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-7Q4B-63XF"] = new() { Id = "JXVII-7Q4B-63XF", Level = 29, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-5Y8C-19VL"] = new() { Id = "JXVII-5Y8C-19VL", Level = 30, Type = TransactionType.Reward, Value = 1 },

            ["JXVII-2N6M-74PA"] = new() { Id = "JXVII-2N6M-74PA", Level = 31, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-8J3T-56QD"] = new() { Id = "JXVII-8J3T-56QD", Level = 32, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-6V7H-28LK"] = new() { Id = "JXVII-6V7H-28LK", Level = 33, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-4R2Y-91XF"] = new() { Id = "JXVII-4R2Y-91XF", Level = 34, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-9M1B-37CP"] = new() { Id = "JXVII-9M1B-37CP", Level = 35, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-3F9L-52VR"] = new() { Id = "JXVII-3F9L-52VR", Level = 36, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-8P4D-61KH"] = new() { Id = "JXVII-8P4D-61KH", Level = 37, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-1X7M-43YN"] = new() { Id = "JXVII-1X7M-43YN", Level = 38, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-6B2V-89LC"] = new() { Id = "JXVII-6B2V-89LC", Level = 39, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-5H8R-24XP"] = new() { Id = "JXVII-5H8R-24XP", Level = 40, Type = TransactionType.Reward, Value = 1 },

            ["JXVII-2L5N-73MF"] = new() { Id = "JXVII-2L5N-73MF", Level = 41, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-7C1Y-58QB"] = new() { Id = "JXVII-7C1Y-58QB", Level = 42, Type = TransactionType.Reward, Value = 1 },
            ["JXVII-4T6P-81XN"] = new() { Id = "JXVII-4T6P-81XN", Level = 43, Type = TransactionType.Reward, Value = 1 },

            ["JXVII-HS87-7R3W"] = new() { Id = "JXVII-HS87-7R3W", Name = "Reparação Histórica da Caixa de Bis", Type = TransactionType.Gift, Value = 1 },
        };
}