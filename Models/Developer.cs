using System.ComponentModel.DataAnnotations;

namespace GameVault.Models;

public class Developer
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [StringLength(60)]
    public string? Country { get; set; }

    [Display(Name = "Founded")]
    public int? FoundedYear { get; set; }

    public ICollection<Game> Games { get; set; } = new List<Game>();
}
