using System.ComponentModel.DataAnnotations;

namespace GameFinder.Model;

public class GameUpdate
{
    [Required]
    public int Id { get; set; }

    [Required, MinLength(1), MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string GameSystem { get; set; } = string.Empty;

    [Required]
    public string Genre { get; set; } = string.Empty;
}
