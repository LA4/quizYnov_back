// using Microsoft.AspNetCore.Mvc;
// using Ynov.QuizzYnov.Business;
// using Ynov.QuizzYnov.Controllers.Dtos;
// using Ynov.QuizzYnov.Controllers.Mappers;
//
// namespace Ynov.QuizzYnov.Controllers;
//
// [Route("api/quizzes")]
// [ApiController]
// public class QuizController : ControllerBase
// {
//     private readonly CategoryMapper _categoryMapper;
//     private readonly QuizMapper _mapper;
//     private readonly IQuizService _service;
//
//     public QuizController(IQuizService service, QuizMapper mapper, CategoryMapper categoryMapper)
//     {
//         _service = service;
//         _mapper = mapper;
//         _categoryMapper = categoryMapper;
//     }
//
//     [HttpGet(Name = "GetAllQuizzes")]
//     [ProducesResponseType(typeof(IEnumerable<QuizDto>), StatusCodes.Status200OK)]
//     [ProducesResponseType(typeof(ErrorDto), StatusCodes.Status404NotFound)]
//     public IActionResult GetAllQuizzes()
//     {
//         IEnumerable<QuizDto> dtos = _service.GetAllQuizzes().Select(quiz => _mapper.ToDto(quiz));
//
//         if (dtos == null)
//         {
//             var error = new ErrorDto
//             {
//                 ErrorCode = "NotFound",
//                 Message = "Quiz not found."
//             };
//             return NotFound(error);
//         }
//
//         return Ok(dtos);
//     }
//
//     [HttpGet("{id}", Name = "GetQuizId")]
//     [ProducesResponseType(typeof(QuizDto), StatusCodes.Status200OK)]
//     [ProducesResponseType(typeof(ErrorDto), StatusCodes.Status404NotFound)]
//     public IActionResult GetQuizId(Guid id)
//     {
//         var dto = _mapper.ToDto(_service.GetQuizId(id));
//         if (dto == null)
//         {
//             var error = new ErrorDto
//             {
//                 ErrorCode = "Invalid id",
//                 Message = $"Quiz not found - id: '{id}'"
//             };
//             return NotFound(error);
//         }
//
//         return Ok(dto);
//     }
//
//
//     [HttpGet("{id}/category")]
//     [ProducesResponseType(typeof(CategoryDto), StatusCodes.Status200OK)]
//     [ProducesResponseType(typeof(ErrorDto), StatusCodes.Status404NotFound)]
//     public IActionResult GetQuizCategoryById(Guid id)
//     {
//         var category = _service.GetQuizCategoryById(id);
//         if (category == null)
//         {
//             var error = new ErrorDto
//             {
//                 ErrorCode = "NotFound",
//                 Message = $"Quiz category not found - id:'{id}'"
//             };
//             return NotFound(error);
//         }
//
//         var categoryDto = _categoryMapper.ToDto(category);
//
//         return Ok(categoryDto);
//     }
// }

