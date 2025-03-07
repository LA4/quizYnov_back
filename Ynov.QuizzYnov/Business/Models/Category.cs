namespace Ynov.QuizzYnov.Business.Models;

public class Category
{
    public int Id { get; set; }
    public string Label { get; set; }
    public ICollection<Quiz> Quizzes { get; set; }
}