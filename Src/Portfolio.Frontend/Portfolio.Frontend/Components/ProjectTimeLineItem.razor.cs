using Microsoft.AspNetCore.Components;

namespace Portfolio.Frontend.Components;

public partial class ProjectTimeLineItem : ComponentBase
{
    [Parameter] public string? TimeLineDate { get; set; }
    [Parameter] public string? ImageSrc { get; set; }
    [Parameter] public string? ImageAlt { get; set; }
    [Parameter] public string? Title { get; set; }
    [Parameter] public string? Description { get; set; }
    [Parameter] public RenderFragment? ChildContent { get; set; }
}