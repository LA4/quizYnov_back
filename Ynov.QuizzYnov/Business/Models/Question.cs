namespace Ynov.QuizzYnov.Business.Models;

public class Question
{
    public int Id { get; set; }
    public virtual string QuestionText { get; set; }
    public virtual ICollection<Response> AnswerChoice { get; set; }
    public virtual Quiz Quiz { get; set; }
}