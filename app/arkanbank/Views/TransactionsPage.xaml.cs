using arkanbank.Models;
using System.Collections.ObjectModel;
using System.Globalization;

namespace arkanbank.Views;

public partial class TransactionsPage : ContentPage {
    public ObservableCollection<TransactionGroup> Transactions { get; } = [];

    public TransactionsPage() {
        InitializeComponent();

        BindingContext = this;
    }

    protected override void OnAppearing() {
        base.OnAppearing();

        LoadTransactions();
    }

    private void LoadTransactions() {
        Transactions.Clear();

        var transactions = App.Wallet.Wallet.Transactions
            .OrderByDescending(x => x.Date)
            .ToList();

        var groups = transactions
            .GroupBy(x => GetDateHeader(x.Date));

        foreach(var group in groups) {
            TransactionGroup transactionGroup =
                new(group.Key);

            foreach(Transaction transaction in group) {
                transactionGroup.Add(transaction);
            }

            Transactions.Add(transactionGroup);
        }
    }

    private static string GetDateHeader(DateTime date) {
        if(date.Date == DateTime.Today)
            return "Hoje";

        if(date.Date == DateTime.Today.AddDays(-1))
            return "Ontem";

        return date.ToString(
            "dd 'de' MMMM",
            new CultureInfo("pt-BR")
        );
    }
}