namespace Portfolio.Frontend.Constants;

public static class AppRoutes
{
    private const string _baseUrl = "/MauroLeonardoPortfolio";
    
    public const string AboutUrl =  $"{_baseUrl}/about-me";
    public const string ContactUrl = $"{_baseUrl}/contact";
    public const string SkillsetUrl = $"{_baseUrl}/skillset";
    public const string HomeUrl = $"{_baseUrl}";
    public const string InternshipsUrl = $"{_baseUrl}/internships";
    public const string ProjectsUrl = $"{_baseUrl}/projects";

    public const string InternshipTctUrl = "tct";
    public const string InternshipCmsUrl = "cms";

    public const string ProjectTrackleUrl = "trackle";
    public const string ProjectHotelKempenrustUrl = "hotel-kempenrust";
    public const string ProjectTtcWestelUrl = "ttc-westel";

    public static string ProjectDetailUrl(string projectName) => $"{_baseUrl}/projects/{projectName}";
}