using arkanbank.Views;

namespace arkanbank {

    public partial class AppShell : Shell {

        public AppShell() {
            InitializeComponent();

            Routing.RegisterRoute(nameof(TransactionsPage), typeof(TransactionsPage));
            Routing.RegisterRoute(nameof(ScanPage), typeof(ScanPage));
        }
    }
}