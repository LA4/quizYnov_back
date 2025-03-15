using Ynov.QuizzYnov.Business.EntityFrameWork.AccessData;
using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.Services;

public class QuizService : IQuizService
{
    private readonly ICategoryService _categoryService;
    private readonly QuizDataAccess _quizDataAccess;
    // private readonly string _quizList = "./Data/quizzes.csv";

    public QuizService(ICategoryService categoryService, QuizDataAccess QuizDataAccess)
    {
        _categoryService = categoryService;
        _quizDataAccess = QuizDataAccess;
    }

    public async Task<List<Quiz>> GetListOfQuiz()
    {
        return await _quizDataAccess.GetQuizzesAsync();
    }

}

