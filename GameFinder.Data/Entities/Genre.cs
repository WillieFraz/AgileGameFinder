using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameFinder.Data.Entities;

public class Genre
{
    [Key]
    public int Id { get; set; }
    
    [Required, MinLength(1), MaxLength(100)]
    public string GenreType { get; set; } = string.Empty;

    [Required, MinLength(1), MaxLength(800)]
    public string Description { get; set; } = string.Empty;
}