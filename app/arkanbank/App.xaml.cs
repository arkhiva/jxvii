namespace arkanbank;

public partial class App : Application {
    public static Services.WalletService Wallet { get; private set; } = null!;

    public App(Services.WalletService walletService) {
        InitializeComponent();
        Wallet = walletService;
    }

    protected override Window CreateWindow(IActivationState? activationState) {
        return new Window(new AppShell());
    }
}