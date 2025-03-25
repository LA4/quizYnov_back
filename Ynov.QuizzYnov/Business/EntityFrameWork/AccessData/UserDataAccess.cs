using Microsoft.EntityFrameworkCore;
using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.EntityFrameWork.AccessData;

public class UserDataAccess(ApplicationDbContext _context):IUserDataAccess
{
    
    public async Task<User?> GetUserByEmail(string email)
    {
        
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email) ?? null;
    }

    public async Task Save(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }
}