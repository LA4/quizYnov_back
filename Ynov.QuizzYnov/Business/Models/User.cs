namespace Ynov.QuizzYnov.Business.Models;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    
    public string Name { get; set; }
    public virtual ICollection<Result> Results { get; set; }
}