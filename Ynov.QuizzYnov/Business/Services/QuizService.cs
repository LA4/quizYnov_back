using Ynov.QuizzYnov.Business.EntityFrameWork.AccessData;
using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.Services;

public class QuizService : IQuizService
{
    private readonly QuizDataAccess _quizDataAccess;

    public QuizService( QuizDataAccess QuizDataAccess)
    {
        _quizDataAccess = QuizDataAccess;
    }

    public async Task<Quiz> AddQuiz(Quiz quiz)
    {
        return await _quizDataAccess.CreateQuizAsync(quiz);
    }

    public async Task<List<Quiz>> GetListOfQuiz()
    {
        return await _quizDataAccess.GetQuizzesAsync();
    }

}

