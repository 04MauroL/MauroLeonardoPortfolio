using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Portfolio.Frontend.Components;

public partial class ButtonComponent : ComponentBase
{
    [Parameter] public Variant Variant { get; set; } = Variant.Filled;
    [Parameter] public bool FullWidth { get; set; } = false;
    [Parameter] public RenderFragment? ChildContent { get; set; }
}