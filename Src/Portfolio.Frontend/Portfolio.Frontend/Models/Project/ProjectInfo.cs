namespace Portfolio.Frontend.Models.Project;

public sealed class ProjectInfo
{
    public string Title { get; init; }
    public string Description { get; init; }
    public List<ProjectDetail> PageDetails { get; init; }
    public List<ProjectDetail> TechStackDetails { get; init; }
    public List<ProjectFile>? DownloadableFiles { get; init; }

    public ProjectInfo(
        string title,
        string description,
        List<ProjectDetail> pageDetails,
        List<ProjectDetail> techStackDetails,
        List<ProjectFile>? downloadableFiles = null)
    {
        Title = title;
        Description = description;
        PageDetails = pageDetails;
        TechStackDetails = techStackDetails;
        DownloadableFiles = downloadableFiles;
    }
}