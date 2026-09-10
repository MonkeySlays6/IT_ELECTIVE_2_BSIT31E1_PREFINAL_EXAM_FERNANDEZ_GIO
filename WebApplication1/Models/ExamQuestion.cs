namespace WebApplication1.Models;
public class ExamQuestion
{
    public int Number { get; set; }
    public string Question { get; set; } = "";
    public List<string> Choices { get; set; } = new();
    public string CorrectAnswer { get; set; } = "";
}