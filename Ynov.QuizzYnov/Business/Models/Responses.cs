namespace Ynov.QuizzYnov.Business.Models;

public class Responses
{
    public Guid Id { get; set; }
    public string CorrectAnswer { get; set; }
    public Guid QuestionId { get; set; }
}