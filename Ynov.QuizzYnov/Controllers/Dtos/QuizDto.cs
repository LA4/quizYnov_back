using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Controllers.Dtos;

public class QuizDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }
    public int Difficulty { get; set; }
    public DateTime CreatedAt { get; set; }
}