namespace Portfolio.Frontend.Constants;

public static class AppRoutes
{
    public const string AboutUrl = "/about-me";
    public const string ContactUrl = "/contact";
    public const string SkillsetUrl = "/skillset";
    public const string HomeUrl = "/";
    public const string InternshipsUrl = "/internships";
    public const string ProjectsUrl = "/projects";

    public const string ProjectHotelKempenrustUrl = "hotel-kempenrust";
    public const string ProjectTtcWestelUrl = "ttc-westel";

    public static string ProjectDetailUrl(string projectName) => $"/project/{projectName}";
}