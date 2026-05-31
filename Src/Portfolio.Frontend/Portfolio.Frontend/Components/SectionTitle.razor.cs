using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Portfolio.Frontend.Components;

public partial class SectionTitle : ComponentBase
{
    [Parameter] public Color Color { get; set; } = Color.Inherit;
    [Parameter] public RenderFragment? ChildContent { get; set; }
}