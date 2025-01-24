using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business;

public interface ICategoryService
{
    IEnumerable<Category> GetAllCategories();
    Category GetCategoryById(Guid? id);
    Category GetCategoryByName(string name);
}