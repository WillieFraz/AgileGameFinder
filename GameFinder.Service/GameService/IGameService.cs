using Microsoft.EntityFrameworkCore;
using GameFinder.Model;

namespace GameFinder.Service.GameService;

public interface IGameService
{
    
    Task<bool> DeleteGameByIdAsync(int gameId);

    Task<bool> UpdateGameItemAsync(GameUpdate update);

}