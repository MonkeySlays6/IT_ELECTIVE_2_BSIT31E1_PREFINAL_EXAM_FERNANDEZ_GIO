using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var questions = new List<ExamQuestion>
        {
            new ExamQuestion
            {
                Number = 1,
                Question = "What is the main problem solved by using a database instead of an in-memory collection?",
                Choices = new List<string>
                {
                    "A. It makes C# code shorter",
                    "B. It prevents the application from restarting",
                    "C. It allows data to persist after the application stops",
                    "D. It removes the need for MVC"
                },
                CorrectAnswer = "C"
            },
            new ExamQuestion
            {
                Number = 2,
                Question = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                Choices = new List<string>
                {
                    "A. Code-First",
                    "B. Database-First",
                    "C. Model-First",
                    "D. Controller-First"
                },
                CorrectAnswer = "B"
            },
            new ExamQuestion
            {
                Number = 3,
                Question = "What is the primary purpose of Entity Framework Core?",
                Choices = new List<string>
                {
                    "A. To create HTML pages automatically",
                    "B. To replace the MVC Controller",
                    "C. To map objects in code to relational database data",
                    "D. To replace the C# compiler"
                },
                CorrectAnswer = "C"
            },
            new ExamQuestion
            {
                Number = 4,
                Question = "Which EF Core component is primarily responsible for communicating with the database?",
                Choices = new List<string>
                {
                    "A. DbContext",
                    "B. DbSetView",
                    "C. ControllerContext",
                    "D. RazorContext"
                },
                CorrectAnswer = "A"
            },
            new ExamQuestion
            {
                Number = 5,
                Question = "What does the following command primarily do?\ndotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                Choices = new List<string>
                {
                    "A. Deletes the database",
                    "B. Creates a new MVC project",
                    "C. Generates EF Core models and a DbContext from an existing database",
                    "D. Starts the MVC application"
                },
                CorrectAnswer = "C"
            },
            new ExamQuestion
            {
                Number = 6,
                Question = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                Choices = new List<string>
                {
                    "A. Program.cs only",
                    "B. appsettings.json",
                    "C. Index.cshtml",
                    "D. Student.cs"
                },
                CorrectAnswer = "B"
            },
            new ExamQuestion
            {
                Number = 7,
                Question = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                Choices = new List<string>
                {
                    "A. One-to-One",
                    "B. One-to-Many",
                    "C. Many-to-Many",
                    "D. Many-to-One only"
                },
                CorrectAnswer = "B"
            },
            new ExamQuestion
            {
                Number = 8,
                Question = "In the following example, what is SectionId?\npublic int SectionId { get; set; }\npublic Section Section { get; set; }",
                Choices = new List<string>
                {
                    "A. Primary key of Student",
                    "B. Foreign key referencing Section",
                    "C. Navigation property",
                    "D. Database connection string"
                },
                CorrectAnswer = "B"
            },
            new ExamQuestion
            {
                Number = 9,
                Question = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                Choices = new List<string>
                {
                    "A. It stores the database password",
                    "B. It represents a relationship to another entity",
                    "C. It creates a new database",
                    "D. It validates the student's name"
                },
                CorrectAnswer = "B"
            },
        };

        return View(questions);
    }
}