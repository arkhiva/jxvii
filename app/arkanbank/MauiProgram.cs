using arkanbank.Services;
using Microsoft.Extensions.Logging;

namespace arkanbank;

public static class MauiProgram {

    public static MauiApp CreateMauiApp() {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()

        #region Fonts

            .ConfigureFonts(fonts => {
                // Fonte principal para textos gerais da interface.
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                // Fonte de ícones no estilo: sólido, regular.
                fonts.AddFont("FA-Pro-Solid.ttf", "IconsSolid");
                fonts.AddFont("FA-Pro-Regular.ttf", "IconsRegular");
            });

        #endregion Fonts

        #region Services

        builder.Services.AddSingleton<WalletService>();

        #endregion Services

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}