using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business;

public interface IQuizService
{
    IEnumerable<Quiz> GetAllQuizzes();
    Quiz GetQuizId(int id);
    Category GetQuizCategoryById(int id);
    IEnumerable<Quiz> GetQuizzesFromCsv();
}