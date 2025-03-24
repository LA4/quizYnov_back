namespace Ynov.QuizzYnov.Business.Models;

public class  Participation
{
    public Guid Id { get; set; }
    public virtual Quiz Quiz { get; set; }
    public virtual User User { get; set; }
    public DateTime TimerStart  { get; set; }
    public DateTime TimerEnd  { get; set; }
    public virtual int  Score { get; set; }
}