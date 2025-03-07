namespace Ynov.QuizzYnov.Business.Models;

public class Quiz
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public Category Category { get; set; }
    public byte Difficulty { get; set; }
    public ICollection<Question> Questions { get; set; }
}