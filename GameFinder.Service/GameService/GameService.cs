using GameFinder.Data;

namespace GameFinder.Service.GameService;

    public class GameService : IGameService
    {
        private readonly ApplicationDbContext _dbContext;

        public GameService (ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext; 
        }
    }
