using Microsoft.EntityFrameworkCore;
using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.EntityFrameWork.AccessData;

public class QuizDataAccess(ApplicationDbContext _context)
{
    public async Task<Quiz> CreateQuizAsync(Quiz quiz)
    {
        _context.Quizzes.Add(quiz);
        await _context.SaveChangesAsync();
        return quiz;
    }
    public async Task<List<Quiz>> GetQuizzesAsync()
    {
        return await _context.Quizzes.ToListAsync();
    }
}