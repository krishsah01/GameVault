using System.ComponentModel.DataAnnotations;

namespace GameVault.Models;

public class Game
{
    public int Id { get; set; }

    [Required, StringLength(150)]
    public string Title { get; set; } = string.Empty;

    [Display(Name = "Released")]
    public int ReleaseYear { get; set; }

    [Required, StringLength(60)]
    public string Platform { get; set; } = string.Empty;

    [Range(1, 10)]
    [Display(Name = "My Rating")]
    public int MyRating { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    // Foreign keys + navigation properties (Game belongs to one Genre and one Developer)
    public int GenreId { get; set; }
    public Genre? Genre { get; set; }

    public int DeveloperId { get; set; }
    public Developer? Developer { get; set; }
}
