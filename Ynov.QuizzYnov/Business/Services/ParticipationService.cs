using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.Services;

public class ParticipationService
{
    private List<Participation> _participationList = new List<Participation>
    {
        new Participation
        {
            Id = new Guid("f9cfdd6d-6267-42ec-a624-a888f990e7b5"),
            Quiz = new Quiz
            {
            },
            User = new User(),
            TimerStart = DateTime.Now,
            TimerEnd = DateTime.Now.AddMinutes(5),
            Score = 123324
        }
    };


    public IEnumerable<Participation> getAll()
    {
        return _participationList;
    }
}