using GameStore.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Models;

public class Games : BaseModel
{
    [Required]
    [StringLength(150, MinimumLength = 4)]
    public required string Name { get; set; }

    [Required]
    [StringLength(250, MinimumLength = 10)]
    public string? ShortDescription { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateOnly ReleaseDate { get; set; }

    [Required]
    public bool IsActive { get; set; }

    [ForeignKey(nameof(Gener))]
    public int? GenerId { get; set; }

    public Gener Gener { get; set; }
}
