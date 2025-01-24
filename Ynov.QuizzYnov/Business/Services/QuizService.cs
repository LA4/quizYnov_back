using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.Services;

public class QuizService : IQuizService
{
    private readonly CategoryService _categoryService;
    private readonly string _quizList = "./Data/quizzes.csv";

    public IEnumerable<Quiz> GetAllQuizzes()
    {
        return GetQuizzesFromCsv();
    }

    public Quiz GetQuizId(Guid id)
    {
        var quiz = GetQuizzesFromCsv().FirstOrDefault(quiz => quiz.Id == id);

        if (quiz == null)
        {
            var error = new Error
            {
                ErrorCode = "NotFound",
                Message = $"Quiz not found for id: '{id}'"
            };
            throw new InvalidOperationException(error.Message);
        }

        return quiz;
    }

    public Category GetQuizCategoryById(Guid id)
    {
        var categoryId = GetQuizzesFromCsv().FirstOrDefault(quiz => quiz.Id == id)?.CategoryId;
        if (categoryId == null)
        {
            var error = new Error
            {
                ErrorCode = "NotFound",
                Message = $"Category not found for id: '{id}'"
            };
            throw new InvalidOperationException(error.Message);
        }

        var category = _categoryService.GetCategoryById(categoryId);


        return category;
    }

    public IEnumerable<Quiz> GetQuizzesFromCsv()
    {
        var quizzes = new List<Quiz>();
        var lines = File.ReadAllLines(_quizList); // Lire toutes les lignes du fichier CSV

        // Ignorer la première ligne (en-tête)
        foreach (var line in lines.Skip(1)) // Skip(1) permet de sauter l'en-tête
        {
            var columns = line.Split(','); // Diviser la ligne en colonnes

            // Créer un objet Quiz à partir des colonnes du CSV
            var quiz = new Quiz
            {
                Id = Guid.Parse(columns[0]),
                CategoryId = Guid.Parse(columns[1]),
                Difficulty = int.Parse(columns[2]),
                Description = columns[3],
                Name = columns[4],
                CreateAt = DateTime.Parse(columns[5])
            };

            quizzes.Add(quiz);
        }

        return quizzes;
    }
}