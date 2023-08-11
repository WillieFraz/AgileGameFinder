using GameFinder.Data.Entities;
using GameFinder.Data;
using GameFinder.Model.GameSystem;

namespace GameFinder.Service.GameSystem;

public class GameSystemService : IGameSystemService
{
    private readonly ApplicationDbContext _dbContext;
    public GameSystemService(ApplicationDbContext db)
    {
        _dbContext = db;
    }
}