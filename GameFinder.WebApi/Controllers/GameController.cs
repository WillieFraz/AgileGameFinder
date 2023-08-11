using Microsoft.AspNetCore.Mvc;
using GameFinder.Service.GameService;
using GameFinder.Model;

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

    [HttpPut]
    public async Task<IActionResult> UpdateGameItemAsync([FromBody] GameUpdate request) {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        return (await _gameService.UpdateGameItemAsync(request)) ? Ok("updated") : BadRequest("Update Fail");
    }

    [HttpDelete("{gameId:int}")]
    public async Task<IActionResult> DeleteGameById([FromRoute] int gameId)
    {
        return await _gameService.DeleteGameByIdAsync(gameId)
            ? Ok($"Game {gameId} was deleted successfully.")
            : BadRequest($"Game {gameId} could not be deleted.");
    }
}