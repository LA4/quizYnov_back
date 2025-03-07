// using Microsoft.AspNetCore.Mvc;
// using Ynov.QuizzYnov.Business;
// using Ynov.QuizzYnov.Business.Models;
// using Ynov.QuizzYnov.Controllers.Dtos;
//
// namespace Ynov.QuizzYnov.Controllers;
//
// [Route("api/questions")]
// [ApiController]
// public class QuestionController : ControllerBase
// {
//     private readonly IQuestionService _service;
//
//     public QuestionController(IQuestionService service)
//     {
//         _service = service;
//     }
//
//
//     [HttpGet("{categoryId}", Name = "QuestionByCategory")]
//     [ProducesResponseType(typeof(Question), StatusCodes.Status200OK)]
//     [ProducesResponseType(typeof(ErrorDto), StatusCodes.Status404NotFound)]
//     public IActionResult GetQuestionByCategory(Guid categoryId)
//     {
//         var questions = _service.GetQuestionByCategory(categoryId);
//         return Ok(questions);
//     }
//
//     [HttpGet("", Name = "getAllQuestions")]
//     [ProducesResponseType(typeof(Question), StatusCodes.Status200OK)]
//     [ProducesResponseType(typeof(ErrorDto), StatusCodes.Status404NotFound)]
//     public IActionResult GetAllQuestions()
//     {
//         var questions = _service.GetAllQuestions();
//         return Ok(questions);
//     }
// }