using System.Collections.ObjectModel;

namespace arkanbank.Models;

public class TransactionGroup : ObservableCollection<Transaction> {
    public string Header { get; }

    public TransactionGroup(string header) {
        Header = header;
    }
}