using GameFinder.Model;

namespace GameFinder.Service.GameService;

public interface IGameService
{
    Task<bool> UpdateGameItemAsync(GameUpdate update);
}