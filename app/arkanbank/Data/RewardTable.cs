using arkanbank.Models;

namespace arkanbank.Data;

public static class RewardTable {

    public static readonly IReadOnlyDictionary<string, RewardItem> Items =
        new Dictionary<string, RewardItem>(StringComparer.OrdinalIgnoreCase) {
            ["JXVII-4D9A-81BC"] = new() { Level = 01, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-8F2K-91LM"] = new() { Level = 02, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-3H7K-82PQ"] = new() { Level = 03, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-7L4M-15QX"] = new() { Level = 04, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-9R2B-47NV"] = new() { Level = 05, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-6C8Y-32FH"] = new() { Level = 06, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-2J6D-84TK"] = new() { Level = 07, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-5N9A-61RE"] = new() { Level = 08, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-8M3P-72GW"] = new() { Level = 09, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-1H5X-93LV"] = new() { Level = 10, Type = TransactionType.Reward, Value = 10 },

            ["JXVII-4Q8F-16KB"] = new() { Level = 11, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-7Y1N-35CP"] = new() { Level = 12, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-2V7J-58MD"] = new() { Level = 13, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-6T4L-27FN"] = new() { Level = 14, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-5B2R-79QJ"] = new() { Level = 15, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-8D6P-43XM"] = new() { Level = 16, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-9A1V-54LC"] = new() { Level = 17, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-3K8M-28YD"] = new() { Level = 18, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-1P4T-95NB"] = new() { Level = 19, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-6R3F-71QH"] = new() { Level = 20, Type = TransactionType.Reward, Value = 10 },

            ["JXVII-4N9C-62XA"] = new() { Level = 21, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-7F5V-18MR"] = new() { Level = 22, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-2C7L-84YP"] = new() { Level = 23, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-5M8H-36VD"] = new() { Level = 24, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-8X1P-53JF"] = new() { Level = 25, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-9L6N-24BK"] = new() { Level = 26, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-3P5X-87MC"] = new() { Level = 27, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-1D9R-45YN"] = new() { Level = 28, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-7Q4B-63XF"] = new() { Level = 29, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-5Y8C-19VL"] = new() { Level = 30, Type = TransactionType.Reward, Value = 10 },

            ["JXVII-2N6M-74PA"] = new() { Level = 31, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-8J3T-56QD"] = new() { Level = 32, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-6V7H-28LK"] = new() { Level = 33, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-4R2Y-91XF"] = new() { Level = 34, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-9M1B-37CP"] = new() { Level = 35, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-3F9L-52VR"] = new() { Level = 36, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-8P4D-61KH"] = new() { Level = 37, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-1X7M-43YN"] = new() { Level = 38, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-6B2V-89LC"] = new() { Level = 39, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-5H8R-24XP"] = new() { Level = 40, Type = TransactionType.Reward, Value = 10 },

            ["JXVII-2L5N-73MF"] = new() { Level = 41, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-7C1Y-58QB"] = new() { Level = 42, Type = TransactionType.Reward, Value = 10 },
            ["JXVII-4T6P-81XN"] = new() { Level = 43, Type = TransactionType.Reward, Value = 10 },
        };
}