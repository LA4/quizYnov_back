using System.Collections;
using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.Services;

public class QuestionService : IQuestionService
{
    private List<Question> _questions = new List<Question>
    {
        new Question
        {
            Id = new Guid("f9cfdd6d-6267-42ec-a624-a888f990e7b5"),
            QuestionText = "dans un chateau",
            AnswerChoice =
                new List<string>
                {
                    "choice1",
                    "choice2",
                    "choice3",
                    "choice4",
                },
        },
        new Question
        {
            Id = new Guid("f9cfdd6d-6267-42ec-a624-a888f990e8b5"),
            QuestionText = "Qu'elle est la  capitale de la bas",
            AnswerChoice =
                new List<string>
                {
                    "choice1",
                    "choice2",
                    "choice3",
                    "choice4",
                },
        },
        new Question
        {
            Id = new Guid("f9cfdd6d-6267-42ec-a624-a888f990e9b5"),
            QuestionText = "Cest quoi la bas",
            AnswerChoice =
                new List<string>
                {
                    "choice1",
                    "choice2",
                    "choice3",
                    "choice4",
                },
        },
        new Question
        {
            Id = new Guid("f9cfdd6d-6267-42ec-a624-a888f990e2b5"),
            QuestionText = "Le conemara ?",
            AnswerChoice = new List<string>
            {
                "choice1",
                "choice2",
                "choice3",
                "choice4",
            },
        }
    };

    public IEnumerable<Question> GetQuestion()
    {
        IEnumerable<Question> questions = _questions;
        if (!questions.Any())
        {
            var error = new Error()
            {
                ErrorCode = "NotFound",
                Message = $"Question list is empty"
            };
            throw new InvalidOperationException(error.Message);
        }

        return questions;
    }
}