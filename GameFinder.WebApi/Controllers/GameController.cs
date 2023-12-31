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

    [HttpPost]
    public async Task<IActionResult> AddGameAsync([FromBody] GameCreate request)
    {
        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return (await _gameService.AddGameAsync(request)) ? Ok("added") : BadRequest("add failed");
    }
}