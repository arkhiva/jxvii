using arkanbank.Views;

namespace arkanbank {

    public partial class AppShell : Shell {

        public AppShell() {
            InitializeComponent();

            Routing.RegisterRoute(
                nameof(TransactionsPage),
                typeof(TransactionsPage)
            );
        }
    }
}