using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business;

public interface IQuizService
{
    IEnumerable<Quiz> GetAllQuizzes();
    Quiz GetQuizId(Guid id);
    Category GetQuizCategoryById(Guid id);
    IEnumerable<Quiz> GetQuizzesFromCsv();
}