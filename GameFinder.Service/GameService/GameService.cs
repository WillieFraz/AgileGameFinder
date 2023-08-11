using GameFinder.Data;
using GameFinder.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameFinder.Service.GameService;

    public class GameService : IGameService
    {
        private readonly ApplicationDbContext _dbContext;

        public GameService (ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext; 
        }

        public async Task<bool> DeleteGameById(int gameId)
        {
        Game? gameEntity = await _dbContext.Games.FindAsync(gameId);
            if (gameEntity == null)
            {
                return false;
            }
            
            if (gameEntity?.OwnerId != _userId)
                return false;

        game = _dbContext.Games.Remove(gameEntity);
            return await _dbContext.SaveChangesAsync() == 1;
        }
    }
