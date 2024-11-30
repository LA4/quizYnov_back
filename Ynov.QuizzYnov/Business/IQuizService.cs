
using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business;

public interface IQuizService
{
     IEnumerable<Quiz> GetAll();
     Quiz GetId(Guid id);
     IEnumerable<Question> GetQuestionById(Guid id);
     Category GetQuizCategoryById(Guid id);

}
