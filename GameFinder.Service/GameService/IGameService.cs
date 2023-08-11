using Microsoft.EntityFrameworkCore;

namespace GameFinder.Service.GameService;

public interface IGameService
{
    
    Task<bool> DeleteGameByIdAsync(int gameId);
}