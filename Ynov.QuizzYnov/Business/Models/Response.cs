namespace Ynov.QuizzYnov.Business.Models;

public class Response
{
    public int Id { get; set; }
    public string Answer { get; set; }
    public string IsValid { get; set; }
    public Question Question { get; set; }
}