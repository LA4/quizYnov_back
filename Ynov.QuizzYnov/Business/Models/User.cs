namespace Ynov.QuizzYnov.Business.Models;

public class User
{
    public int Id { get; set; }
    public string userName { get; set; }
    public ICollection<Result> Results { get; set; }
}