namespace Portfolio.Frontend.Models.Project;

public sealed class ProjectDetail
{
    public string Title { get; init; }
    public string Description { get; init; }
    public string ImageSrc { get; init; }
    public string ImageAlt { get; init; }

    public ProjectDetail(string title, string description, string imageSrc, string imageAlt)
    {
        Title = title;
        Description = description;
        ImageSrc = imageSrc;
        ImageAlt = imageAlt;
    }
}