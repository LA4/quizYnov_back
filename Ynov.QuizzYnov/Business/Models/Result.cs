namespace Ynov.QuizzYnov.Business.Models;

public class Result
{
    public int Id { get; set; }
    public Quiz Quiz { get; set; }
    public User User { get; set; }
    public int Score { get; set; }
    
}