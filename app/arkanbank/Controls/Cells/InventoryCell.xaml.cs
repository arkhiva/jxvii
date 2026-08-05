using arkanbank.Models;

namespace arkanbank.Controls.Cells;

public partial class InventoryCell : ContentView {

    public event EventHandler<string>? Clicked;

    public static readonly BindableProperty NameProperty =
        BindableProperty.Create(
            nameof(Name),
            typeof(string),
            typeof(InventoryCell),
            string.Empty,
            propertyChanged: OnPropertyChanged);

    public static readonly BindableProperty DescriptionProperty =
        BindableProperty.Create(
            nameof(Description),
            typeof(string),
            typeof(InventoryCell),
            string.Empty,
            propertyChanged: OnPropertyChanged);

    public static readonly BindableProperty CategoryProperty =
        BindableProperty.Create(
            nameof(Category),
            typeof(InventoryCategory),
            typeof(InventoryCell),
            InventoryCategory.Hint,
            propertyChanged: OnPropertyChanged);

    public static readonly BindableProperty EmojiProperty =
        BindableProperty.Create(
            nameof(Emoji),
            typeof(string),
            typeof(InventoryCell),
            string.Empty,
            propertyChanged: OnPropertyChanged);

    public static readonly BindableProperty IconProperty =
        BindableProperty.Create(
            nameof(Icon),
            typeof(string),
            typeof(InventoryCell),
            string.Empty,
            propertyChanged: OnPropertyChanged);

    public static readonly BindableProperty IconBackgroundProperty =
        BindableProperty.Create(
            nameof(IconBackground),
            typeof(Color),
            typeof(InventoryCell),
            Colors.Transparent,
            propertyChanged: OnPropertyChanged);

    public static readonly BindableProperty IdProperty =
        BindableProperty.Create(
            nameof(Id),
            typeof(string),
            typeof(InventoryCell),
            string.Empty);

    public string Name {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }

    public string Description {
        get => (string)GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }

    public InventoryCategory Category {
        get => (InventoryCategory)GetValue(CategoryProperty);
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

    public string Id {
        get => (string)GetValue(IdProperty);
        set => SetValue(IdProperty, value);
    }

    public InventoryCell() {
        InitializeComponent();
    }

    private static void OnPropertyChanged(
        BindableObject bindable,
        object oldValue,
        object newValue) {
        if(bindable is InventoryCell control)
            control.Refresh();
    }

    private void Refresh() {
        UpdateIcon();

        UpdateCategory();

        UpdateAction();
    }

    private void UpdateAction() {
        actionContainer.IsVisible =
            Category == InventoryCategory.Hint &&
            Clicked != null;
    }

    private void Button_Clicked(object sender, EventArgs e) {
        Clicked?.Invoke(this, Id);
    }

    private void UpdateIcon() {
        if(!string.IsNullOrEmpty(Icon)) {
            icon.Text = Icon;
            icon.IsVisible = true;

            emoji.Text = string.Empty;
            emoji.IsVisible = false;
        } else if(!string.IsNullOrEmpty(Emoji)) {
            emoji.Text = Emoji;
            emoji.IsVisible = true;

            icon.Text = string.Empty;
            icon.IsVisible = false;
        } else {
            emoji.IsVisible = false;
            icon.IsVisible = false;
        }
    }

    private void UpdateCategory() {
        category.Text = Category switch {
            InventoryCategory.Hint =>
                "Dica",

            InventoryCategory.Experience =>
                "Experiência",

            InventoryCategory.Feature =>
                "Funcionalidade",

            _ =>
                string.Empty
        };

        categoryBorder.BackgroundColor = Category switch {
            InventoryCategory.Hint =>
                Color.FromArgb("#00B8D9"),

            InventoryCategory.Experience =>
                Color.FromArgb("#FF8A00"),

            InventoryCategory.Feature =>
                Color.FromArgb("#7B61FF"),

            _ =>
                Color.FromArgb("#999999")
        };
    }
}