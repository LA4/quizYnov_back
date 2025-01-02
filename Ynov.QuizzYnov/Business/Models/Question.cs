namespace Ynov.QuizzYnov.Business.Models;

public class Question
{
    public Guid Id { get; set; }
    public string QuestionText { get; set; }
    public List<string> AnswerChoice { get; set; }
 
}