using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.EntityFrameWork.AccessData;

public class UserDataAccess(ApplicationDbContext _context)
{
    public async Task<User?> Find(int userId)
    {
        return await _context.Users.FindAsync(userId);
    }

    public async Task Add(User? user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }
}