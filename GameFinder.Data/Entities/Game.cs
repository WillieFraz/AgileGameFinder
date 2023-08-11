using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameFinder.Data.Entities;

public class Game
{
    [Key]
    public int Id { get; set; }

    [Required, MinLength(1), MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    [ForeignKey(nameof(GameSystem))]
    public int GameSystemId { get; set; } 
    
    public GameSystem GameSystem { get; set; } = new();

    [ForeignKey(nameof(Genre))]
    public int GenreId { get; set; }
    
    public Genre Genre { get; set; } = new();
}
