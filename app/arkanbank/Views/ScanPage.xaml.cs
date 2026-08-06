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
        if(TicketPopup.IsVisible) { return true; }
        return base.OnBackButtonPressed();
    }

    private void QrTabTapped(object sender, TappedEventArgs e) {
        if(qrSelected) { return; }
        qrSelected = true;
        UpdateTabs();
    }

    private void CodeTabTapped(object sender, TappedEventArgs e) {
        if(!qrSelected) { return; }
        qrSelected = false;
        UpdateTabs();
    }

    private void UpdateTabs() {
        QrLayout.IsVisible = qrSelected;
        CodeLayout.IsVisible = !qrSelected;

        CameraView.IsDetecting = qrSelected;

        if(qrSelected) {
            QrTab.BackgroundColor = Application.Current.RequestedTheme == AppTheme.Light ? StaticResourceUtility.Get<Color>("Primary") : StaticResourceUtility.Get<Color>("PrimaryDark");
            CodeTab.BackgroundColor = Application.Current.RequestedTheme == AppTheme.Light ? StaticResourceUtility.Get<Color>("Gray100") : StaticResourceUtility.Get<Color>("Gray600");
        } else {
            CodeTab.BackgroundColor = Application.Current.RequestedTheme == AppTheme.Light ? StaticResourceUtility.Get<Color>("Primary") : StaticResourceUtility.Get<Color>("PrimaryDark");
            QrTab.BackgroundColor = Application.Current.RequestedTheme == AppTheme.Light ? StaticResourceUtility.Get<Color>("Gray100") : StaticResourceUtility.Get<Color>("Gray600");
        }
    }

    private void CodeEntry_TextChanged(object sender, EventArgs e) {
        if(CodeEntry.Text is null) { return; }

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
    // QR
    // =========================================================

    private async void CameraView_BarcodesDetected(object sender, BarcodeDetectionEventArgs e) {
        if(scanned) { return; }

        var result = e.Results.FirstOrDefault();
        if(result is null) { return; }

        scanned = true;
        CameraView.IsDetecting = false;

        await RedeemQrCode(result.Value);
    }

    // =========================================================
    // PROCESSAMENTO
    // =========================================================

    private async Task RedeemQrCode(string encryptedValue) {
        try {
            await ShowToast("🔍 Analisando código...");
            await Task.Delay(800);

            var ticketValue = Cryptography.Decrypt(encryptedValue);
            if(string.IsNullOrWhiteSpace(ticketValue)) {
                await ShowToast("🛑 Código inválido.");
                await Task.Delay(3000);
                return;
            }

            if(!TicketTable.Items.TryGetValue(ticketValue, out var ticket)) {
                await ShowToast("🛑 Ticket inválido.");
                await Task.Delay(3000);
                return;
            }

            switch(ticket.Type) {
                case TransactionType.Reward: {
                    await RedeemReward(ticket);
                    break;
                }
                case TransactionType.Gift: {
                    await RedeemGift(ticket);
                    break;
                }
                default: {
                    await ShowToast("⚠️ Tipo de ticket desconhecido.");
                    break;
                }
            }
        } catch(Exception ex) {
            await ShowToast("⚠️ Erro ao processar QR Code.");
#if DEBUG
            System.Diagnostics.Debug.WriteLine(ex);
#endif
        } finally {
            if(!TicketPopup.IsVisible) { ResetScanner(); }
        }
    }

    // =========================================================
    // REWARD
    // =========================================================

    private async Task RedeemReward(TicketItem ticket) {
        if(App.Wallet.IsRewardRedeemed(ticket.Id)) {
            await ShowToast("⚠️ Ticket já resgatado.");
            await Task.Delay(3000);
            return;
        }

        App.Wallet.AddMoney(ticket.Value, $"Recompensa Nível {ticket.Level}", TransactionType.Reward);
        App.Wallet.RegisterReward(ticket.Id);

        await ShowTicketPopup(new PopupInfo {
            Title = "Recompensa Resgatada!",
            Description = $"Você concluiu o nível {ticket.Level}.",
            Value = $"N$ {ticket.Value}",
            Icon = "\uf5a2",
            Color = Colors.MediumPurple
        });
    }

    private async Task RedeemGift(TicketItem ticket) {
        if(App.Wallet.IsRewardRedeemed(ticket.Id)) {
            await ShowToast("⚠️ Presente já resgatado.");
            await Task.Delay(3000);
            return;
        }

        App.Wallet.AddMoney(ticket.Value, ticket.Name, TransactionType.Gift);
        App.Wallet.RegisterReward(ticket.Id);

        await ShowTicketPopup(new PopupInfo {
            Title = "Presente Resgatado!",
            Description = ticket.Name,
            Value = $"N$ {ticket.Value}",
            Icon = "\uf06b",
            Color = Colors.Gold
        });
    }

    // =========================================================
    // TICKET
    // =========================================================

    private async void RedeemButton_Clicked(object sender, EventArgs e) {
        if(scanned) { return; }
        scanned = true;

        try {
            var ticket = CodeEntry.Text?.Trim();

            if(string.IsNullOrWhiteSpace(ticket) || ticket.Length != 13) {
                await ShowToast("🛑 Informe um ticket válido.");
                return;
            }

            ticket = ticket.Insert(5, "-").Insert(10, "-");
            CodeEntry.Unfocus();
            string encryptedTicket = Cryptography.Encrypt(ticket);
            await RedeemQrCode(encryptedTicket);
        } finally {
            if(!TicketPopup.IsVisible)
                scanned = false;
        }
    }

    // =========================================================
    // AUXILIARES
    // =========================================================

    private static Task ShowToast(string message) {
        return MainThread.InvokeOnMainThreadAsync(() => Toast.Make(message).Show());
    }

    private void ResetScanner() {
        scanned = false;
        if(qrSelected) { CameraView.IsDetecting = true; }
    }

    private async Task ShowTicketPopup(PopupInfo popup) {
        await MainThread.InvokeOnMainThreadAsync(() => {
            PopupTitle.Text = popup.Title;
            PopupDescription.Text = popup.Description;
            PopupValue.Text = popup.Value;
            PopupIcon.Text = popup.Icon;
            PopupIconBackground.BackgroundColor = popup.Color;
            PopupValue.TextColor = popup.Color;
            TicketPopup.IsVisible = true;
        });
    }

    private async void TicketPopupButton_Clicked(object sender, EventArgs e) {
        TicketPopup.IsVisible = false;
        CodeEntry.Text = string.Empty;
        ResetScanner();
        await Shell.Current.GoToAsync("//MainPage");
    }
}