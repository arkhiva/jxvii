using arkanbank.Models;

namespace arkanbank.Controls.Cells;

public partial class ExtractCell : ContentView {

    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(
            nameof(Title),
            typeof(string),
            typeof(ExtractCell),
            string.Empty,
            propertyChanged: OnPropertyChanged);

    public static readonly BindableProperty DateProperty =
        BindableProperty.Create(
            nameof(Date),
            typeof(DateTime),
            typeof(ExtractCell),
            DateTime.Now,
            propertyChanged: OnPropertyChanged);

    public static readonly BindableProperty AmountProperty =
        BindableProperty.Create(
            nameof(Amount),
            typeof(int),
            typeof(ExtractCell),
            0,
            propertyChanged: OnPropertyChanged);

    public static readonly BindableProperty TypeProperty =
        BindableProperty.Create(
            nameof(Type),
            typeof(TransactionType),
            typeof(ExtractCell),
            TransactionType.System,
            propertyChanged: OnPropertyChanged);

    public string Title {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public DateTime Date {
        get => (DateTime)GetValue(DateProperty);
        set => SetValue(DateProperty, value);
    }

    public int Amount {
        get => (int)GetValue(AmountProperty);
        set => SetValue(AmountProperty, value);
    }

    public TransactionType Type {
        get => (TransactionType)GetValue(TypeProperty);
        set => SetValue(TypeProperty, value);
    }

    public ExtractCell() {
        InitializeComponent();

        Application.Current.RequestedThemeChanged += Current_RequestedThemeChanged;

        Refresh();
    }

    private static void OnPropertyChanged(BindableObject bindable, object oldValue, object newValue) {
        if(bindable is ExtractCell control)
            control.Refresh();
    }

    private void Refresh() {
        title.Text = Title;

        // Data
        if(Date.Date == DateTime.Today) {
            date.Text = $"Hoje • {Date:HH:mm}";
        } else if(Date.Date == DateTime.Today.AddDays(-1)) {
            date.Text = $"Ontem • {Date:HH:mm}";
        } else {
            date.Text = Date.ToString("dd/MM/yyyy • HH:mm");
        }

        // Valor
        amount.Text = $"{(Amount >= 0 ? "+" : "-")}N$ {Math.Abs(Amount)}";

        UpdateAmountColor();

        // Ícone
        switch(Type) {
            case TransactionType.Reward: {
                // Medalha.
                icon.Text = "\uf5a2";
                break;
            }
            case TransactionType.Purchase: {
                // Carrinho de compras.
                icon.Text = "\uf07a";
                break;
            }
            case TransactionType.Gift: {
                // Presente.
                icon.Text = "\uf06b";
                break;
            }
            case TransactionType.Secret: {
                // Cadeado.
                icon.Text = "\uf023";
                break;
            }
            case TransactionType.Bonus: {
                // Moedas.
                icon.Text = "\uf51e";
                break;
            }
            default: {
                // Carteira.
                icon.Text = "\uf555";
                break;
            }
        }
    }

    private void Current_RequestedThemeChanged(object? sender, AppThemeChangedEventArgs e) {
        UpdateAmountColor();
    }

    private void UpdateAmountColor() {
        if(Amount > 0) {
            amount.TextColor =
                Application.Current.RequestedTheme == AppTheme.Light
                    ? StaticResourceUtility.Get<Color>("Green")
                    : StaticResourceUtility.Get<Color>("GreenDark");
        } else if(Amount < 0) {
            amount.TextColor =
                Application.Current.RequestedTheme == AppTheme.Light
                    ? StaticResourceUtility.Get<Color>("Error")
                    : StaticResourceUtility.Get<Color>("ErrorDark");
        } else {
            amount.TextColor =
                Application.Current.RequestedTheme == AppTheme.Light
                    ? StaticResourceUtility.Get<Color>("Gray600")
                    : StaticResourceUtility.Get<Color>("Gray300");
        }
    }
}