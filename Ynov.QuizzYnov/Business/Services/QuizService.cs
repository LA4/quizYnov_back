﻿using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.Services;

public class QuizService : IQuizService
{
    private List<Quiz> _quizList = new List<Quiz>
    {
        new Quiz
        {
            Id = new Guid("f9cfdd6d-6267-42ec-a624-a888f990e7b5"),
            Category =
                new Category
                {
                    Id = new Guid("e8fe7125-746e-4219-9db7-a277ea485c29"),
                    Name = "Concepts de programmation",
                    CreateAt = DateTime.Now.ToLocalTime()
                },
            Difficulty = 2,
            Description = "ASP .NET Core 2.0 Quiz",
            Name = "Architect",
            CreateAt = DateTime.Now.ToLocalTime()
        },  new Quiz
        {
            Id = new Guid("f9cfdd6d-6267-42ec-a624-a888f990e7b5"),
            Category =
                new Category
                {
                    Id = new Guid("a877f0cf-0e74-496a-a9cc-20d551622a76"),
                    Name = "Langages de programmation",
                    CreateAt = DateTime.Now.ToLocalTime()
                },
            Difficulty = 3,
            Description = "ASP .NET Core 2.0 Quiz",
            Name = "Dev back M1",
            CreateAt = DateTime.Now.ToLocalTime()
        }, new Quiz
        {
            Id = new Guid("f9cfdd6d-6267-42ec-a624-a888f990e7b5"),
            Category =
                new Category
                {
                    Id = new Guid("5be51e2c-7959-43ed-b684-c5ee920fc497"),
                    Name = "APIs et web services",
                    CreateAt = DateTime.Now.ToLocalTime()
                },
            Difficulty = 1,
            Description = "ASP .NET Core 2.0 Quiz",
            Name = "Dev Fullstack M1",
            CreateAt = DateTime.Now.ToLocalTime()
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
    public Category GetQuizCategoryById(Guid id)
    {
        return _quizList.Find(quiz => quiz.Id == id).Category;
    }
}