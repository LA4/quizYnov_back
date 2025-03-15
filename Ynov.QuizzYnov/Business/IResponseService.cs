using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business;

public interface IResponseService
{
    Response GetResponseByQuestion(Guid questionId);
    bool GetResponseResult(Guid questionId, string playerResponse);
}