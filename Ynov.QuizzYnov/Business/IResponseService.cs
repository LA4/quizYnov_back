using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business;

public interface IResponseService
{
    Responses GetResponseByQuestion(Guid questionId);
    bool GetResponseResult(Guid questionId, string playerResponse);
}