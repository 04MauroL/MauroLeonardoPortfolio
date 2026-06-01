using Microsoft.AspNetCore.Components;
using Portfolio.Frontend.Models.Project;

namespace Portfolio.Frontend.Pages;

public partial class ProjectDetail : ComponentBase
{
    public readonly ProjectInfo ProjectInfoDetails;
    [Parameter] public string ProjectName { get; set; } = string.Empty;

    public ProjectDetail()
    {
        ProjectInfoDetails = new ProjectInfo(
            title: "Project Name",
            description:
            "During my 2024 internship at AllPhi Westerlo, I collaborated with my fellow intern Govart to develop the Consultant Management System (CMS). The CMS is designed to serve as a single platform where HR can access all consultant data and update it across other platforms such as Salesforce, SD Worx, and others.",
            pageDetails:
            [
                new Models.Project.ProjectDetail("PageTest", "TestDescription", "images/home/Mauro.jpg", "Ik"),
                new Models.Project.ProjectDetail("PageTest", "TestDescription", "images/home/Mauro.jpg", "Ik"),
                new Models.Project.ProjectDetail("PageTest", "TestDescription", "images/home/Mauro.jpg", "Ik")
            ],
            techStackDetails:
            [
                new Models.Project.ProjectDetail("TechTest", "TestDescription", "images/skillset/Blazor-Logo.png",
                    "Ik"),
                new Models.Project.ProjectDetail("TechTest", "TestDescription", "images/skillset/Angular-Logo.png",
                    "Ik"),
            ]); //ToDo: Load from json
    }
}