using Ynov.QuizzYnov.Business.Models;
using Ynov.QuizzYnov.Controllers.Dtos;

namespace Ynov.QuizzYnov.Controllers.Mappers;

public class QuestionMapper
{
    public QuestionDto ToDto(Question question)
    {
        return new QuestionDto
        {
            Id = question.Id,
            QuestionText = question.QuestionText,
            AnwserChoise = question.AnswerChoice,
            CategoryId = question.CategoryId
        };
    }
}