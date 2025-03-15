using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business;

public interface IQuizService
{
    Task<List<Quiz>> GetListOfQuiz();
}