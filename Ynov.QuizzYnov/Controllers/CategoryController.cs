using Microsoft.AspNetCore.Mvc;
using Ynov.QuizzYnov.Business;
using Ynov.QuizzYnov.Business.Models;
using Ynov.QuizzYnov.Controllers.Dtos;
using Ynov.QuizzYnov.Controllers.Mappers;

namespace Ynov.QuizzYnov.Controllers;

[Route("api/categories")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    private readonly CategoryMapper _categoryMapper;

    public CategoryController(ICategoryService categoryService, CategoryMapper categoryMapper)
    {
        _categoryService = categoryService;
        _categoryMapper = categoryMapper;
    }


    [HttpGet(Name = "getCategories")]
    [ProducesResponseType(typeof(IEnumerable<Category>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorDto), StatusCodes.Status404NotFound)]
    public IActionResult GetAllCategories()
    {
        IEnumerable<CategoryDto> dtos = _categoryService.GetAllCategories()
            .Select(category => _categoryMapper.ToDto(category));
        if (dtos == null)
        {
            var error = new ErrorDto()
            {
                ErrorCode = "NotFound",
                Message = "Quiz not found."
            };
            return NotFound(error);
        }

        return Ok(dtos);
    }

    [HttpGet("{id}", Name = "getCategoryById")]
    [ProducesResponseType(typeof(IEnumerable<Category>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorDto), StatusCodes.Status404NotFound)]
    public IActionResult GetCategoryById(Guid id)
    {
        Category dtos = _categoryService.GetCategoryById(id);

        if (dtos == null)
        {
            var error = new ErrorDto()
            {
                ErrorCode = "NotFound",
                Message = "Quiz not found."
            };
            return NotFound(error);
        }

        CategoryDto categoryDto = _categoryMapper.ToDto(dtos);
        return Ok(categoryDto);
    }
}