using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business;

public interface IQuestionService
{
    IEnumerable<Question> GetAllQuestions();
    Question GetQuestionById(Guid questionId);
    IEnumerable<Question> GetQuestionByCategory(Guid categoryId);
}