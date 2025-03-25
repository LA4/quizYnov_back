using System.Security.Claims;
using Ynov.QuizzYnov.Business.EntityFrameWork.AccessData;
using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.Services;

public class UserService(IUserDataAccess _dataAccess) : IUserService
{
    public async Task HandleSuccessfulSignin(IEnumerable<Claim> claims)
    {
        var emailClaim = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
        var nameClaim = claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
        if (emailClaim != null || nameClaim != null)
        {
            var user =await  _dataAccess.GetUserByEmail(emailClaim);
            if (user == null)
            {
                user = new User
                {
                    Name = nameClaim,
                    Email = emailClaim,
                };
                await _dataAccess.Save(user);
            }
        }
    }

    public async Task<User?> getCurrent(IEnumerable<Claim> claims)
    {
        return await _dataAccess.GetUserByEmail(claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value) ?? null;
    }
}