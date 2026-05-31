using Microsoft.AspNetCore.Components;

namespace Portfolio.Frontend.Components;

public partial class SectionSubTitle : ComponentBase
{
    [Parameter] public required RenderFragment? ChildContent { get; set; }
}