using Microsoft.AspNetCore.Components;

namespace Portfolio.Frontend.Components;

public partial class SectionTitle : ComponentBase
{
    [Parameter] public required RenderFragment? ChildContent { get; set; }
}