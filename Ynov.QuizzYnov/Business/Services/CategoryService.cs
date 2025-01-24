using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.Services;

public class CategoryService : ICategoryService
{
    private readonly string _categoriesList = "./Data/categories.csv";


    public IEnumerable<Category> GetAllCategories()
    {
        return GetCategoriesFromCsv();
    }

    public Category GetCategoryById(Guid? id)
    {
        var category = GetCategoriesFromCsv().FirstOrDefault(c => c.Id == id);
        if (category == null) throw new InvalidOperationException("Category not found");
        return category;
    }

    public Category GetCategoryByName(string name)
    {
        var category = GetCategoriesFromCsv().FirstOrDefault(c => c.Name == name);
        if (category == null) throw new InvalidOperationException("Category not found");
        return category;
    }

    private IEnumerable<Category> GetCategoriesFromCsv()
    {
        var categories = new List<Category>();
        var lines = File.ReadAllLines(_categoriesList);
        foreach (var line in lines.Skip(1))
        {
            var columns = line.Split(',');

            var category = new Category
            {
                Id = Guid.Parse(columns[0]),
                Name = columns[1],
                CreateAt = DateTime.Parse(columns[2])
            };

            categories.Add(category);
        }

        return categories;
    }
}