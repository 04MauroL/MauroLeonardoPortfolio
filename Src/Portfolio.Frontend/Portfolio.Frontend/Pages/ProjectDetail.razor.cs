using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using Portfolio.Frontend.Models.Project;

namespace Portfolio.Frontend.Pages;

public partial class ProjectDetail : ComponentBase
{
    [Inject] public HttpClient HttpClient { get; set; } = null!;

    public ProjectInfo? ProjectInfoDetails { get; set; }
    [Parameter] public string ProjectName { get; set; } = string.Empty;

    protected override async Task OnParametersSetAsync()
    {
        if (!string.IsNullOrWhiteSpace(ProjectName))
        {
            try
            {
                ProjectInfoDetails = await HttpClient.GetFromJsonAsync<ProjectInfo>($"projects/{ProjectName}.json");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading project data: {ex.Message}");
            }
        }
    }
}