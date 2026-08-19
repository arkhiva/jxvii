using arkanbank.Views;

namespace arkanbank {

    public partial class AppShell : Shell {

        public AppShell() {
            InitializeComponent();

            Routing.RegisterRoute(nameof(TransactionsPage), typeof(TransactionsPage));
            Routing.RegisterRoute(nameof(ScanPage), typeof(ScanPage));
            Routing.RegisterRoute(nameof(StorePage), typeof(StorePage));
            Routing.RegisterRoute(nameof(StoreHintPage), typeof(StoreHintPage));
            Routing.RegisterRoute(nameof(StoreExperiencePage), typeof(StoreExperiencePage));
            Routing.RegisterRoute(nameof(StoreFeaturePage), typeof(StoreFeaturePage));
            Routing.RegisterRoute(nameof(InventoryPage), typeof(InventoryPage));

            Routing.RegisterRoute(nameof(FidgetSpinnerPage), typeof(FidgetSpinnerPage));
        }
    }
}