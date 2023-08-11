using GameFinder.Model;
namespace GameFinder.Service.GameService;

public interface IGameService
{
    Task<GameDetail?> GetGameByIdAsync(int Id); // <- add property (GameUpdate update)
}