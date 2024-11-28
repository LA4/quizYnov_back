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
    private readonly IQuizService _service;
    private readonly QuizMapper _mapper;

    public QuizController(IQuizService service, QuizMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet(Name = "GetQuiz")]
    [ProducesResponseType(typeof(IEnumerable<QuizDto>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        IEnumerable<QuizDto> dtos = _service.getAll().Select(quiz => _mapper.ToDto(quiz));
        return Ok(dtos);
    }

    [HttpGet("{id}", Name = "GetQuizId")]
    [ProducesResponseType(typeof(QuizDto), StatusCodes.Status200OK)]
    public IActionResult GetId(Guid id)
    {
        Quiz dto = _service.GetId(id);
        if (dto == null) return BadRequest("Quiz not found");
        QuizDto dtoResponse = _mapper.ToDto(dto);
        return Ok(dtoResponse);
    }

    [HttpGet("{id}/question", Name = "GetQuizQuestionById")]
    [ProducesResponseType(typeof(QuizDto), StatusCodes.Status200OK)]
    public IActionResult GetQuestionByQuiz(Guid id)
    {
        IEnumerable<Question> dtoQuestion = _service.GetQuestionById(id);
        if (dtoQuestion == null) return BadRequest("Question not found");
        return Ok(dtoQuestion);
    }
}