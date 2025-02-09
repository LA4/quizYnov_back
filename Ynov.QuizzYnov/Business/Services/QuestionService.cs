using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.Services;

public class QuestionService : IQuestionService
{
    private readonly string _questionList = "./Data/questions.csv";

    public IEnumerable<Question> GetAllQuestions()
    {
        return GetQuestionsFromCsv();
    }

    public Question GetQuestionById(Guid questionId)
    {
        return GetQuestionsFromCsv().FirstOrDefault(q => q.Id == questionId);
    }

    public IEnumerable<Question> GetQuestionByCategory(Guid categoryId)
    {
        var questions = GetQuestionsFromCsv();
        return questions.Where(q => q.CategoryId == categoryId);
    }

    private IEnumerable<Question> GetQuestionsFromCsv()
    {
        var questions = new List<Question>();
        var lines = File.ReadAllLines(_questionList);
        foreach (var line in lines.Skip(1))
        {
            char[] charsToTrim = { ' ', '\\', '"' };
            var columns = line.Split(';');
            var questiontext = columns[1].Trim(charsToTrim);
            var answerchoices = columns[2].Trim(charsToTrim);
            var question = new Question
            {
                Id = Guid.Parse(columns[0]),
                QuestionText = questiontext,
                AnswerChoice = answerchoices
                    .Trim('[', ']')
                    .Split(',')
                    .Select(choice => choice.Trim(' ', '\'', '\\'))
                    .ToList(),
                CategoryId = Guid.Parse(columns[3])
            };

            questions.Add(question);
        }

        return questions;
    }
}