using GameFinder.Data.Entities;
using GameFinder.Model;
using GameFinder.Data;

namespace GameFinder.Service.GameService;

    public class GameService : IGameService
    {
        private readonly ApplicationDbContext _dbContext;

        public GameService (ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext; 
        }

        public async Task<bool> UpdateGameItemAsync(GameUpdate request) {
            Game? game = await _dbContext.Games.FindAsync(request.Id);
        
            game.Title = request.Title;
            game.GameSystem = request.GameSystem;
            game.Genre = request.Genre;

            return await _dbContext.SaveChangesAsync() == 1;
        }

        public async Task<bool> DeleteGameByIdAsync(int gameId)
        {
            Game? game = await _dbContext.Games.FindAsync(gameId);
            if (game is null)
                return false;
        
            _dbContext.Games.Remove(game);
            return await _dbContext.SaveChangesAsync() == 1;
        }

   
}
