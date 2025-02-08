using Microsoft.AspNetCore.Mvc;
using Ynov.QuizzYnov.Business;
using Ynov.QuizzYnov.Business.Models;
using Ynov.QuizzYnov.Controllers.Dtos;

namespace Ynov.QuizzYnov.Controllers;

[Route("api/responses")]
[ApiController]
public class ResponseController : ControllerBase
{
    private readonly IQuestionService _questionService;
    private readonly IResponseService _responseService;

    public ResponseController(IResponseService responseServiceService, IQuestionService questionService)
    {
        _responseService = responseServiceService;
        _questionService = questionService;
    }

    [HttpGet("{questionId}/{playerResponse}", Name = "getResponseByQuestion")]
    [ProducesResponseType(typeof(IEnumerable<Responses>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorDto), StatusCodes.Status404NotFound)]
    public IActionResult GetResponseByQuestion(Guid questionId, string playerResponse)
    {
        var responseResult = _responseService.GetResponseResult(questionId, playerResponse);
        return Ok(responseResult);
    }
}