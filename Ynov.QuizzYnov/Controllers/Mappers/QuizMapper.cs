using Ynov.QuizzYnov.Business;
using Ynov.QuizzYnov.Business.Models;
using Ynov.QuizzYnov.Controllers.Dtos;

namespace Ynov.QuizzYnov.Controllers.Mappers;

public class QuizMapper
{
    private readonly ICategoryService _categoryService;

    public QuizMapper(ICategoryService categoryService)
    {
        _categoryService = categoryService ;
    }
    public QuizDto ToDto(Quiz quiz)
    {
        return new QuizDto
        {
            Id = quiz.Id,
            Description = quiz.Description,
            Difficulty = quiz.Difficulty,
            Name = quiz.Name,
            Category = _categoryService.GetCategoryById(quiz.CategoryId),
            CreatedAt = quiz.CreateAt
        };
    }
}