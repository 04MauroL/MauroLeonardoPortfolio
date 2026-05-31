using Microsoft.AspNetCore.Components;
using Color = MudBlazor.Color;

namespace Portfolio.Frontend.Components;

public partial class Section : ComponentBase
{
    [Parameter] public string? Class { get; set; }
    [Parameter] public Color BackgroundColor { get; set; } = Color.Tertiary;
    [Parameter] public RenderFragment? ChildContent { get; set; }
}