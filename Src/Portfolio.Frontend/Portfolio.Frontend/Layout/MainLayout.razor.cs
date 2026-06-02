using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Portfolio.Frontend.Layout;

public partial class MainLayout : LayoutComponentBase
{
    private readonly MudTheme _theme = new()
    {
        PaletteLight = new PaletteLight
        {
            Primary = "#4C6991",
            Secondary = Colors.LightGreen.Darken2,
            Tertiary = Colors.Gray.Lighten4,
            Background = Colors.Gray.Lighten4,
            AppbarBackground = Colors.Gray.Lighten4
        }
    };
}