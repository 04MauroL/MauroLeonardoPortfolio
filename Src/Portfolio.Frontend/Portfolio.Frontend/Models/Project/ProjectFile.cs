namespace Portfolio.Frontend.Models.Project;

public sealed class ProjectFile
{
    public string Name { get; init; }
    public string Url { get; init; }

    public ProjectFile(string name, string url)
    {
        Name = name;
        Url = url;
    }
}