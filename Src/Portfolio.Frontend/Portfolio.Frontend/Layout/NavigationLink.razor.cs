using Microsoft.AspNetCore.Components;

namespace Portfolio.Frontend.Layout;

public partial class NavigationLink : ComponentBase
{
    [Parameter] public string Href { get; set; } = string.Empty;
    [Parameter] public string Label { get; set; } = string.Empty;
    [Parameter] public RenderFragment? ChildContent { get; set; }
}