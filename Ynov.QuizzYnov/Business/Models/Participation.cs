namespace Ynov.QuizzYnov.Business.Models;

public class Participation
{
    public Guid Id { get; set; }
    public Quiz Quiz { get; set; }
    public User User { get; set; }
    public DateTime TimerStart  { get; set; }
    public DateTime TimerEnd  { get; set; }
    public int Score { get; set; }
}