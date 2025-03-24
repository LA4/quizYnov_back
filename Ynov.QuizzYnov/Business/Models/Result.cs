namespace Ynov.QuizzYnov.Business.Models;

public class Result
{
    public int Id { get; set; }
    public virtual Quiz Quiz { get; set; }
    public virtual User User { get; set; }
    public int Score { get; set; }
    
}