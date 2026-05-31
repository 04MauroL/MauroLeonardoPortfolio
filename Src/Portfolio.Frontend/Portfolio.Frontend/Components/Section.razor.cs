using Microsoft.AspNetCore.Components;
using Color = MudBlazor.Color;

namespace Portfolio.Frontend.Components;

public partial class Section : ComponentBase
{
    [Parameter] public required Color BackgroundColor { get; set; } = Color.Tertiary;
    [Parameter] public required RenderFragment? ChildContent { get; set; }
}