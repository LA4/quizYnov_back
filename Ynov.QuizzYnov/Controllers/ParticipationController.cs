// using Microsoft.AspNetCore.Mvc;
// using Ynov.QuizzYnov.Business;
// using Ynov.QuizzYnov.Business.Models;
// using Ynov.QuizzYnov.Controllers.Mappers;
//
// namespace Ynov.QuizzYnov.Controllers;
//
// [Route("api/particitations")]
// [ApiController]
// public class ParticipationController : ControllerBase
// {
//     private readonly IParticipationService _service;
//     private readonly ParticipationMapper _mapper;
//
//     public ParticipationController(IParticipationService service, ParticipationMapper mapper)
//     {
//         _service = service;
//         _mapper = mapper;
//     }
//
//     [HttpGet("participations")]
//     [ProducesResponseType(typeof(IEnumerable<Participation>), StatusCodes.Status200OK)]
//     public IActionResult GetAll()
//     {
//         return Ok();
//     }
// }