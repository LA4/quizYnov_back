using Microsoft.AspNetCore.Mvc;
using Ynov.QuizzYnov.Business;
using Ynov.QuizzYnov.Business.Models;
using Ynov.QuizzYnov.Controllers.Dtos;
using Ynov.QuizzYnov.Controllers.Mappers;

namespace Ynov.QuizzYnov.Controllers;

[Route("api/quizzes")]
[ApiController]
public class QuizController : ControllerBase
{
    private readonly QuizMapper _mapper;
    private readonly IQuizService _quizService;

    public QuizController(IQuizService quizService, QuizMapper mapper)
    {
        _quizService = quizService;
        _mapper = mapper;
    }

    [HttpGet(Name = "GetAllQuizzes")]
    [ProducesResponseType(typeof(IEnumerable<QuizDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorDto), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAllQuizzes()
    {
        List<Quiz> quizzes = await _quizService.GetListOfQuiz();
        List<QuizDto> quizzesDto = quizzes.Select(q => _mapper.ToDto(q))
            .ToList();
        if (quizzesDto == null)
        {
            return NotFound();
        }

        return Ok(quizzesDto);
    }

    [HttpPost(Name = "CreateQuiz")]
    [ProducesResponseType(typeof(Quiz), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorDto), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CreateQuiz(Quiz newQuiz)
    {
        newQuiz = await _quizService.AddQuiz(newQuiz);
        return Ok(newQuiz);
    }
}