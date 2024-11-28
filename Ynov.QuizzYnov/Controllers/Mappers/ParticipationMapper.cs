using Ynov.QuizzYnov.Business.Models;
using Ynov.QuizzYnov.Controllers.Dtos;

namespace Ynov.QuizzYnov.Controllers.Mappers;

public class ParticipationMapper
{
    public ParticipationDto ToDto(Participation participation)
    {
        return new ParticipationDto
        {
            Id = participation.Id,
            Quiz = participation.Quiz,
            User = participation.User,
            TimerStart = participation.TimerStart,
            TimerEnd = participation.TimerEnd,
            Score = participation.Score,
        };
    }
}