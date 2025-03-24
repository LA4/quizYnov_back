using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business;

public interface IQuizService
{
    Task<Quiz> AddQuiz(Quiz quiz);
    Task<List<Quiz>> GetListOfQuiz();
}