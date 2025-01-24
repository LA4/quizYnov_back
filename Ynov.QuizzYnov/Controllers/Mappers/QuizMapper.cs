using Ynov.QuizzYnov.Business.Models;
using Ynov.QuizzYnov.Business.Services;
using Ynov.QuizzYnov.Controllers.Dtos;

namespace Ynov.QuizzYnov.Controllers.Mappers;

public class QuizMapper
{
    private readonly QuizService _quizService;

    public QuizDto ToDto(Quiz quiz)
    {
        return new QuizDto
        {
            Id = quiz.Id,
            Description = quiz.Description,
            Difficulty = quiz.Difficulty,
            Name = quiz.Name,
            CategoryName = _quizService.GetQuizCategoryById(quiz.CategoryId).Name,
            CreatedAt = quiz.CreateAt
        };
    }
}