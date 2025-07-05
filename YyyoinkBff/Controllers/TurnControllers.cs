using Microsoft.AspNetCore.Mvc;
using YyyoinkBff.Contracts.Turn;

namespace YyyoinkBff.Controllers;

[ApiController]
public class TurnControllers: ControllerBase
{
    [HttpPost("/turn")]
    public IActionResult CreateTurn(CreatePromptRequest request)
    {
        return Ok(request);
    }
    
    [HttpGet("/turn/{id:guid}")]
    public IActionResult GetTurn(Guid id)
    {
        return Ok(id);
    }
    
    [HttpDelete("/turn/{id:guid}")]
    public IActionResult DeleteTurn(Guid id)
    {
        return Ok(id);
    }
}