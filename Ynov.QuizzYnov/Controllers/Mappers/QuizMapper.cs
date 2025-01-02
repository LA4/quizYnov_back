using Ynov.QuizzYnov.Business.Models;
using Ynov.QuizzYnov.Controllers.Dtos;

namespace Ynov.QuizzYnov.Controllers.Mappers;

public class QuizMapper
{
    public QuizDto ToDto(Quiz quiz)
    {
        return new QuizDto()
        {
            Id = quiz.Id,
            Description = quiz.Description,
            Difficulty = quiz.Difficulty,
            Name = quiz.Name,
            CategoryName = quiz.Category.Name,
            CreatedAt = quiz.CreateAt
        };
    }
}