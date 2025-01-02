using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Ynov.QuizzYnov.Business;
using Ynov.QuizzYnov.Business.Models;
using Ynov.QuizzYnov.Controllers.Dtos;

namespace Ynov.QuizzYnov.Controllers;

[Route("api/questions")]
[ApiController]
public class QuestionController : ControllerBase
{
    private readonly IQuestionService _service;

    public QuestionController(IQuestionService service)
    {
        _service = service;
    }

    [HttpGet(Name = "Question")]
    [ProducesResponseType(typeof(Question), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorDto), StatusCodes.Status404NotFound)]
    public IActionResult GetQuestions()
    {
        IEnumerable<Question> questions = _service.GetQuestion();
        if (questions == null)
        { 
            var error = new ErrorDto
            {
                ErrorCode = "Invalid",
                Message = $" "
            };
            return NotFound(error);
        }

        return Ok(questions);
    }
}