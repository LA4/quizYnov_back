using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.Services;

public class CategoryService
{
    private List<Category> _categories = new List<Category>
    {
        new Category
        {
            Id = new Guid("e8fe7125-746e-4219-9db7-a277ea485c29"),
            Name = "Langages de programmation",
            CreateAt = DateTime.Now.ToLocalTime()
        },
        new Category
        {
            Id = new Guid("a877f0cf-0e74-496a-a9cc-20d551622a76"),
            Name = "Concepts de programmation",
            CreateAt = DateTime.Now.ToLocalTime()
        },
        new Category
        {
            Id = new Guid("5be51e2c-7959-43ed-b684-c5ee920fc497"),
            Name = "APIs et web services",
            CreateAt = DateTime.Now.ToLocalTime()
        }
    };


    public IEnumerable<Category> GetAllCategories()
    {
        return _categories;
    }

    public  Category GetCategoryById(Guid id)
    {
        return _categories.FirstOrDefault(x => x.Id == id);
    }
}