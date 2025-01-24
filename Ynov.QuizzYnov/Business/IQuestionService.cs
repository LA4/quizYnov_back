using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business;

public interface IQuestionService
{
    IEnumerable<Question> GetAllQuestions();
    IEnumerable<Question> GetQuestionByCategory(Guid categoryId);
}