using Microsoft.AspNetCore.Mvc;
using GameFinder.Service.GameService;

namespace GameFinder.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class GameController : ControllerBase
{
    private readonly IGameService _gameService;
    public GameController(IGameService gameService)
    {
        _gameService = gameService;
    }

    [HttpGet("{Id:int}")]
    public async Task<IActionResult> GetGameByIdAsync([FromRoute] int Id) //(int id)?
    {
        var game = await _gameService.GetGameByIdAsync(Id);

        if (game == null)
        {
            return NotFound();
        }

        return Ok(game);
    }
}