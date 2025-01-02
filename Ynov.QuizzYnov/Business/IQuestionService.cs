using System.Collections;
using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business;

public interface IQuestionService
{
    IEnumerable<Question> GetQuestion();
}