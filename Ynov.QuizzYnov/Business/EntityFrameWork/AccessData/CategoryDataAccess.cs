using Microsoft.EntityFrameworkCore;
using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.EntityFrameWork.AccessData;

public class CategoryDataAccess(ApplicationDbContext _context)
{
    public async Task<List<Category>> GetCategories()
    {
        return await _context.Categories.ToListAsync();
    }
}