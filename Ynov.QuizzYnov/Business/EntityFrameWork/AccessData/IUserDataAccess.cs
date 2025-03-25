using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.EntityFrameWork.AccessData;

public interface IUserDataAccess
{
    Task<User?> GetUserByEmail(string email);
    Task Save(User user);
}