using arkanbank.Data;
using arkanbank.Models;
using arkanbank.Security;
using CommunityToolkit.Maui.Alerts;
using ZXing.Net.Maui;

namespace arkanbank.Views;

public partial class ScanPage : ContentPage {
    private bool qrSelected = true;
    private bool scanned;

    public ScanPage() {
        InitializeComponent();

        Application.Current.RequestedThemeChanged += Current_RequestedThemeChanged;

        UpdateTabs();
    }

    protected override void OnAppearing() {
        base.OnAppearing();

        CameraView.IsDetecting = qrSelected;
    }

    protected override void OnDisappearing() {
        base.OnDisappearing();

        CameraView.IsDetecting = false;
    }

    protected override bool OnBackButtonPressed() {
        if(RewardPopup.IsVisible)
            return true;

        return base.OnBackButtonPressed();
    }

    private void QrTabTapped(object sender, TappedEventArgs e) {
        if(qrSelected)
            return;

        qrSelected = true;

        UpdateTabs();
    }

    private void CodeTabTapped(object sender, TappedEventArgs e) {
        if(!qrSelected)
            return;

        qrSelected = false;

        UpdateTabs();
    }

    private void UpdateTabs() {
        QrLayout.IsVisible = qrSelected;
        CodeLayout.IsVisible = !qrSelected;

        CameraView.IsDetecting = qrSelected;

        if(qrSelected) {
            QrTab.BackgroundColor =
                Application.Current.RequestedTheme == AppTheme.Light
                    ? StaticResourceUtility.Get<Color>("Primary")
                    : StaticResourceUtility.Get<Color>("PrimaryDark");

            CodeTab.BackgroundColor =
                Application.Current.RequestedTheme == AppTheme.Light
                    ? StaticResourceUtility.Get<Color>("Gray100")
                    : StaticResourceUtility.Get<Color>("Gray600");
        } else {
            CodeTab.BackgroundColor =
                Application.Current.RequestedTheme == AppTheme.Light
                    ? StaticResourceUtility.Get<Color>("Primary")
                    : StaticResourceUtility.Get<Color>("PrimaryDark");

            QrTab.BackgroundColor =
                Application.Current.RequestedTheme == AppTheme.Light
                    ? StaticResourceUtility.Get<Color>("Gray100")
                    : StaticResourceUtility.Get<Color>("Gray600");
        }
    }

    private void CodeEntry_TextChanged(object sender, EventArgs e) {
        if(CodeEntry.Text is null)
            return;

        string upper = CodeEntry.Text.ToUpperInvariant();

        if(CodeEntry.Text != upper) {
            CodeEntry.Text = upper;
            CodeEntry.CursorPosition = upper.Length;
        }
    }

    private void Current_RequestedThemeChanged(object? sender, AppThemeChangedEventArgs e) {
        UpdateTabs();
    }

    // =========================================================
    // QR CODE
    // =========================================================

    private async void CameraView_BarcodesDetected(object sender, BarcodeDetectionEventArgs e) {
        if(scanned)
            return;

        var result = e.Results.FirstOrDefault();

        if(result is null)
            return;

        scanned = true;

        CameraView.IsDetecting = false;

        await RedeemQrCode(result.Value);
    }

    // =========================================================
    // PROCESSAMENTO PRINCIPAL
    // Recebe SEMPRE código criptografado
    // =========================================================

    private async Task RedeemQrCode(string encryptedValue) {
        try {
            await ShowToast("🔍 Analisando Código...");
            await Task.Delay(1000);

            var qrCode = Cryptography.Decrypt(encryptedValue);

            if(qrCode is null) {
                await ShowToast("🛑 Código Inválido!");
                await Task.Delay(4000);
                return;
            }

            switch(qrCode.Type) {
                case TransactionType.Reward: {
                    if(!RewardTable.Items.TryGetValue(
                        qrCode.Value,
                        out var reward)) {
                        await ShowToast("🛑 Ticket Inválido!");
                        await Task.Delay(4000);
                        return;
                    }

                    if(App.Wallet.IsRewardRedeemed(qrCode.Value)) {
                        await ShowToast("⚠️ Ticket já resgatado!");
                        await Task.Delay(4000);
                        return;
                    }

                    App.Wallet.AddMoney(
                        reward.Value,
                        $"Recompensa Nível {reward.Level}",
                        TransactionType.Reward);

                    App.Wallet.RegisterReward(
                        qrCode.Value);

                    await ShowRewardPopup(
                        reward.Value,
                        reward.Level);

                    break;
                }

                default: {
                    // Outros tipos futuramente

                    break;
                }
            }
        } catch(Exception ex) {
            await ShowToast(
                "⚠️ Ocorreu um erro ao processar o QR Code.");

#if DEBUG
            System.Diagnostics.Debug.WriteLine(ex);
#endif
        } finally {
            if(!RewardPopup.IsVisible)
                ResetScanner();
        }
    }

    // =========================================================
    // TICKET DIGITADO
    // Converte para o mesmo fluxo do QR
    // =========================================================

    private async void RedeemButton_Clicked(object sender, EventArgs e) {
        if(scanned)
            return;

        scanned = true;

        try {
            var ticket = CodeEntry.Text?.Trim();

            if(string.IsNullOrWhiteSpace(ticket) ||
               ticket.Length != 13) {
                await ShowToast(
                    "🛑 Informe um ticket válido...");

                return;
            }

            ticket = ticket.Insert(5, "-").Insert(10, "-");

            CodeEntry.Unfocus();

            // O ticket digitado precisa entrar
            // no mesmo formato do QR Code.
            var encryptedTicket =
                Cryptography.Encrypt(
                    new QrCodeItem {
                        Type = TransactionType.Reward,
                        Value = ticket
                    });

            await RedeemQrCode(encryptedTicket);
        } finally {
            if(!RewardPopup.IsVisible)
                scanned = false;
        }
    }

    // =========================================================
    // AUXILIARES
    // =========================================================

    private static Task ShowToast(string message) {
        return MainThread.InvokeOnMainThreadAsync(() =>
            Toast.Make(message).Show());
    }

    private void ResetScanner() {
        scanned = false;

        if(qrSelected)
            CameraView.IsDetecting = true;
    }

    private async Task ShowRewardPopup(
        int value,
        int level) {
        await MainThread.InvokeOnMainThreadAsync(() => {
            RewardDescription.Text =
                $"Você recebeu N${value} pela recompensa do nível {level}.";

            RewardPopup.IsVisible = true;
        });
    }

    private async void RewardPopupButton_Clicked(
        object sender,
        EventArgs e) {
        RewardPopup.IsVisible = false;

        CodeEntry.Text = string.Empty;

        ResetScanner();

        await Shell.Current.GoToAsync("//MainPage");
    }
}