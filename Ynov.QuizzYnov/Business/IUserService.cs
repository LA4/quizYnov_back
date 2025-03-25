using System.Security.Claims;
using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business;

public interface IUserService
{
    Task HandleSuccessfulSignin(IEnumerable<Claim> claims);
    Task<User> getCurrent(IEnumerable<Claim> claims);
}