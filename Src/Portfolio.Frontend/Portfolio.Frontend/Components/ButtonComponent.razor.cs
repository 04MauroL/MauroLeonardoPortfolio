using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Portfolio.Frontend.Components;

public partial class ButtonComponent : ComponentBase
{
    [Parameter] public Variant Variant { get; set; } = Variant.Outlined;
    [Parameter] public Color Color { get; set; } = Color.Primary;
    [Parameter] public Color TextColor { get; set; } = Color.Primary;
    [Parameter] public bool FullWidth { get; set; }
    [Parameter] public string? Href { get; set; }
    [Parameter] public RenderFragment? ChildContent { get; set; }
}