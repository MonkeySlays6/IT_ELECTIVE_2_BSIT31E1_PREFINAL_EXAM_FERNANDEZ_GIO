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
                ChosenAnswer = "C"
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
                ChosenAnswer = "B"
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
                ChosenAnswer = "C"
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
                ChosenAnswer = "A"
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
                ChosenAnswer = "C"
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
                ChosenAnswer = "B"
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
                ChosenAnswer = "B"
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
                ChosenAnswer = "B"
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
                ChosenAnswer = "B"
            },
            new ExamQuestion
            {
                Number = 10,
                Question = "What does .Include() generally allow EF Core to do?",
                Choices = new List<string>
                {
                    "A. Delete the Section table",
                    "B. Load related Section data together with Students",
                    "C. Create a new Student",
                    "D. Validate Student input"
                },
                ChosenAnswer = "B"
            },
            new ExamQuestion
            {
                Number = 11,
                Question = "Why might a ViewModel be used when displaying Student and Section information?",
                Choices = new List<string>
                {
                    "A. To replace the database",
                    "B. To combine or shape the data specifically needed by the view",
                    "C. To automatically create database tables",
                    "D. To prevent controllers from using LINQ"
                },
                ChosenAnswer = "B"
            },
            new ExamQuestion
            {
                Number = 12,
                Question = "Consider this query:\nvar students = _context.Students.Include(s => s.Section).ToList();\nWhat is the main benefit of Include(s => s.Section)?",
                Choices = new List<string>
                {
                    "A. It loads the related Section navigation property",
                    "B. It creates a Section object manually",
                    "C. It removes the foreign key",
                    "D. It prevents the query from accessing the database"
                },
                ChosenAnswer = "A"
            },
            new ExamQuestion
            {
                Number = 13,
                Question = "Which type of validation occurs in the browser before a request is sent to the server?",
                Choices = new List<string>
                {
                    "A. Database-level validation",
                    "B. Client-side validation",
                    "C. Server-side validation",
                    "D. EF Core migration validation"
                },
                ChosenAnswer = "B"
            },
            new ExamQuestion
            {
                Number = 14,
                Question = "Why is server-side validation still necessary if client-side validation exists?",
                Choices = new List<string>
                {
                    "A. Client-side validation can be bypassed",
                    "B. Client-side validation automatically modifies the database",
                    "C. Server-side validation only works with SQLite",
                    "D. Client-side validation cannot display messages"
                },
                ChosenAnswer = "A"
            },
            new ExamQuestion
            {
                Number = 15,
                Question = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
                Choices = new List<string>
                {
                    "A. Student Number should always be nullable",
                    "B. Student Number should be unique",
                    "C. Student Number should always be the same",
                    "D. Student Number should contain only spaces"
                },
                ChosenAnswer = "B"
            },
        };

        return View(questions);
    }
}