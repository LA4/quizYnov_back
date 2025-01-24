namespace Ynov.QuizzYnov.Business.Models;

public class Quiz
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid CategoryId { get; set; }
    public IEnumerable<Question> Questions { get; set; }
    public int Difficulty { get; set; }
    public DateTime CreateAt { get; set; }
}