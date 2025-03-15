namespace Ynov.QuizzYnov.Business.Models;

public class Response
{
    public int Id { get; set; }
    public string ResponseItem { get; set; }
    public bool IsValid { get; set; }
    public Question Question { get; set; }
}