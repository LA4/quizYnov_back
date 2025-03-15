
using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.EntityFrameWork.AccessData;

public class ResponseDataAccess(ApplicationDbContext _context)
{
    public async Task<Response?> GetResponseById(int id)
    {
        return await _context.Responses.FindAsync(id);
    }
}