using Microsoft.EntityFrameworkCore;
using GameFinder.Model;

namespace GameFinder.Service.GameService;

public interface IGameService
{    
    Task<bool> DeleteGameByIdAsync(int gameId);

    Task<GameDetail?> GetGameByIdAsync(int Id); // <- add property (GameUpdate update)

    Task<bool> UpdateGameItemAsync(GameUpdate update);


}