using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Controllers.Dtos;

public class QuestionDto
{
    public Guid Id { get; set; }
    public string QuestionText { get; set; }
    public string AnwserChoise { get; set; }
}