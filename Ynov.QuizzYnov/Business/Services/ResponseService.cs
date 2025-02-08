using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.Services;

public class ResponseService : IResponseService
{
    private readonly string _responseList = "./Data/responses.csv";

    public Responses GetResponseByQuestion(Guid questionId)
    {
        var response = GetresponsesFromCsv();
        return response.FirstOrDefault(r => r.QuestionId == questionId);
    }

    public bool GetResponseResult(Guid questionId, string playerResponse)
    {
        var response = GetResponseByQuestion(questionId);

        if (response.CorrectAnswer.Trim().ToLower() == playerResponse.Trim().ToLower()) return true;

        return false;
    }

    private IEnumerable<Responses> GetresponsesFromCsv()
    {
        var responses = new List<Responses>();
        var lines = File.ReadAllLines(_responseList);
        foreach (var line in lines.Skip(1))
        {
            var columns = line.Split(',');

            var response = new Responses
            {
                Id = Guid.Parse(columns[0]),
                QuestionId = Guid.Parse(columns[1]),
                CorrectAnswer = columns[2]
            };

            responses.Add(response);
        }

        return responses;
    }
}