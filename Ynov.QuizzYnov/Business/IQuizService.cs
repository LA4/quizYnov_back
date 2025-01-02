
using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business;

public interface IQuizService
{
     IEnumerable<Quiz> GetAll();
     Quiz GetId(Guid id);
     Category GetQuizCategoryById(Guid id);

}
