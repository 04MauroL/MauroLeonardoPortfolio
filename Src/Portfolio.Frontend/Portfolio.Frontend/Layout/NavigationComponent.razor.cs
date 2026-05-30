using Microsoft.AspNetCore.Components;

namespace Portfolio.Frontend.Layout;

public partial class NavigationComponent : ComponentBase
{
    private const string AboutUrl = "/about";
    private const string ContactUrl = "/contact";
    private const string HomeUrl = "/";
    private const string InternshipsUrl = "/internships";
    private const string ProjectsUrl = "/projects";

    private string _currentPath = string.Empty;
    [Inject] private NavigationManager NavigationManager { get; set; } = null!;

    protected override void OnInitialized()
    {
        var relative = NavigationManager.ToBaseRelativePath(NavigationManager.Uri);
        _currentPath = "/" + relative.TrimEnd('/');
        if (_currentPath == "/") _currentPath = "/";
    }

    private bool IsActive(string href)
    {
        var target = href.TrimEnd('/');
        var current = _currentPath.TrimEnd('/');

        return current.Equals(target, StringComparison.OrdinalIgnoreCase);
    }
}