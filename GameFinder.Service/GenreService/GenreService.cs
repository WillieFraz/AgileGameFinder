using GameFinder.Model.GenreModels;
using GameFinder.Data.Entities;
using GameFinder.Data;

namespace GameFinder.Service.Genre;

public class GenreService : IGenreService
{
    private readonly ApplicationDbContext _dbContext;
    public GenreService(ApplicationDbContext db)
    {
        _dbContext = db;
    }
}