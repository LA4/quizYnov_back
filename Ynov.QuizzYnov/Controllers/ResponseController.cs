using Microsoft.AspNetCore.Mvc;
using Ynov.QuizzYnov.Business;
using Ynov.QuizzYnov.Business.Models;
using Ynov.QuizzYnov.Controllers.Dtos;
using Ynov.QuizzYnov.Controllers.Mappers;

namespace Ynov.QuizzYnov.Controllers;

[Route("api/responses")]
[ApiController]
public class ResponseController : ControllerBase
{
    private readonly IQuestionService _questionService;
    private readonly IResponseService _responseService;
    private readonly ResponseMapper _responseMapper;

    public ResponseController(
        IResponseService responseServiceService,
        IQuestionService questionService,ResponseMapper responseMapper)
    {
        _responseService = responseServiceService;
        _questionService = questionService;
        _responseMapper = responseMapper;
    }

    [HttpGet("{questionId}/{playerResponse}", Name = "getResponseByQuestion")]
    [ProducesResponseType(typeof(IEnumerable<Response>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorDto), StatusCodes.Status404NotFound)]
    public IActionResult GetResponseByQuestion(Guid questionId, string playerResponse)
    {
        var responseResult = _responseService.GetResponseResult(questionId, playerResponse);
        var responseResultDto = _responseMapper.ToDto(responseResult);
        return Ok(responseResultDto);
    }
}