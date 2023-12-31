using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameFinder.Model;

public class GameDetail
{
    [Required, MinLength(1), MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string GameSystem { get; set; } = string.Empty;
    
    [Required]
    public string Genre { get; set; } = string.Empty;
}

