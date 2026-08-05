using arkanbank.Models;

namespace arkanbank.Controls.Cells;

public partial class StoreCell : ContentView {

    public static readonly BindableProperty IdProperty =
        BindableProperty.Create(
            nameof(Id),
            typeof(string),
            typeof(StoreCell),
            string.Empty);

    public static readonly BindableProperty NameProperty =
        BindableProperty.Create(
            nameof(Name),
            typeof(string),
            typeof(StoreCell),
            string.Empty,
            propertyChanged: OnPropertyChanged);

    public static readonly BindableProperty DescriptionProperty =
        BindableProperty.Create(
            nameof(Description),
            typeof(string),
            typeof(StoreCell),
            string.Empty,
            propertyChanged: OnPropertyChanged);

    public static readonly BindableProperty CategoryProperty =
        BindableProperty.Create(
            nameof(Category),
            typeof(StoreCategory),
            typeof(StoreCell),
            StoreCategory.Hint,
            propertyChanged: OnPropertyChanged);

    public static readonly BindableProperty EmojiProperty =
        BindableProperty.Create(
            nameof(Emoji),
            typeof(string),
            typeof(StoreCell),
            string.Empty,
            propertyChanged: OnPropertyChanged);

    public static readonly BindableProperty IconProperty =
        BindableProperty.Create(
            nameof(Icon),
            typeof(string),
            typeof(StoreCell),
            string.Empty,
            propertyChanged: OnPropertyChanged);

    public static readonly BindableProperty IconBackgroundProperty =
        BindableProperty.Create(
            nameof(IconBackground),
            typeof(Color),
            typeof(StoreCell),
            Colors.Transparent,
            propertyChanged: OnPropertyChanged);

    public static readonly BindableProperty PriceProperty =
        BindableProperty.Create(
            nameof(Price),
            typeof(int),
            typeof(StoreCell),
            0,
            propertyChanged: OnPropertyChanged);

    public string Id {
        get => (string)GetValue(IdProperty);
        set => SetValue(IdProperty, value);
    }

    public string Name {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }

    public string Description {
        get => (string)GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }

    public StoreCategory Category {
        get => (StoreCategory)GetValue(CategoryProperty);
        set => SetValue(CategoryProperty, value);
    }

    public string Emoji {
        get => (string)GetValue(EmojiProperty);
        set => SetValue(EmojiProperty, value);
    }

    public string Icon {
        get => (string)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public Color IconBackground {
        get => (Color)GetValue(IconBackgroundProperty);
        set => SetValue(IconBackgroundProperty, value);
    }

    public int Price {
        get => (int)GetValue(PriceProperty);
        set => SetValue(PriceProperty, value);
    }

    public event EventHandler? Clicked;

    public StoreCell() {
        InitializeComponent();
    }

    private static void OnPropertyChanged(
        BindableObject bindable,
        object oldValue,
        object newValue) {
        if(bindable is StoreCell control)
            control.Refresh();
    }

    private void Refresh() {
        UpdateIcon();
        UpdateCategory();
        UpdatePrice();
    }

    private void UpdateIcon() {
        if(!string.IsNullOrWhiteSpace(Icon)) {
            icon.Text = Icon;
            icon.IsVisible = true;

            emoji.Text = string.Empty;
            emoji.IsVisible = false;
        } else if(!string.IsNullOrWhiteSpace(Emoji)) {
            emoji.Text = Emoji;
            emoji.IsVisible = true;

            icon.Text = string.Empty;
            icon.IsVisible = false;
        } else {
            icon.IsVisible = false;
            emoji.IsVisible = false;
        }
    }

    private void UpdateCategory() {
        category.Text = Category switch {
            StoreCategory.Hint => "DICA",

            StoreCategory.Experience => "EXPERIÊNCIA",

            StoreCategory.Feature => "FUNCIONALIDADE",

            _ => string.Empty
        };

        categoryBorder.BackgroundColor = Category switch {
            StoreCategory.Hint => Color.FromArgb("#009CB8"),

            StoreCategory.Experience => Color.FromArgb("#C96D00"),

            StoreCategory.Feature => Color.FromArgb("#7B61FF"),

            _ => Color.FromArgb("#999999")
        };
    }

    private void UpdatePrice() {
        price.Text = $"N$ {Price:N0}";
    }

    private void Button_Clicked(object sender, EventArgs e) {
        Clicked?.Invoke(this, EventArgs.Empty);
    }
}