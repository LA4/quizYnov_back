using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business;

public interface IParticipationService
{
    IEnumerable<Participation> getAll();
}