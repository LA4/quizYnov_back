using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.Services;

public class QuizService : IQuizService
{
    private List<Quiz> _quizList = new List<Quiz>
    {
        new Quiz
        {
            Id= new Guid("f9cfdd6d-6267-42ec-a624-a888f990e7b5"),
            Category = new Category{Id = new Guid("b6a8f92b-29dc-4572-b148-255fd5d808c0")}
            ,Difficulty = 3,
            Description = "ASP .NET Core 2.0 Quiz",
            Name = "Dev Fullstack M1",
            CreateAt =  DateTime.Now.ToLocalTime()
        }
    };
    

    public IEnumerable<Quiz> getAll()
    {
        return _quizList;
    }

    public Quiz? GetId(Guid id)
    {
        return _quizList.Find(quiz => quiz.Id == id);
    }

    public IEnumerable<Question> GetQuestionById(Guid id)
    {
        return GetId(id).Questions;
    }
}