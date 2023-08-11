using Microsoft.AspNetCore.Mvc;
using GameFinder.Service.GameService;
using GameFinder.Model;

namespace GameFinder.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class GameSystemController : ControllerBase
{
    private readonly IGameSystemService _gameSystemService;

    public GameSystemController (IGameSystemService gameSystem) 
    {
        _gameSystemService = gameSystem;
    }

}