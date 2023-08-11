using GameFinder.Data.Entities;
using GameFinder.Model;
using GameFinder.Data;


namespace GameFinder.Service.GameService;

public class GameService : IGameService
{
    private readonly ApplicationDbContext _dbContext;

    public GameService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<GameDetail?> GetGameByIdAsync(int Id) //GameEntity
    {
        Game? game = await _dbContext.Games.FindAsync(Id);
        if (game is null)
            return null;
        return new GameDetail()
        {
        //  Id = game.Id,
            Title = game.Title,
            GameSystem = game.GameSystem,
            Genre = game.Genre
        };
    }
}
