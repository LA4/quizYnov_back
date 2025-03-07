namespace Ynov.QuizzYnov.Business.Models;

public class Question
{
    public int Id { get; set; }
    public string QuestionText { get; set; }
    public ICollection<Responses> AnswerChoice { get; set; }
    public Quiz Quiz { get; set; }
}