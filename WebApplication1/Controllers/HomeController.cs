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
        };

        return View(questions);
    }
}