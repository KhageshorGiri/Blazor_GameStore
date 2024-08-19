using GameStore.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models;

public class Gener : BaseModel
{
    [Required]
    [StringLength(100, MinimumLength = 4)]
    public required string Name { get; set; }

    public ICollection<Games> Games { get; set; }   
}
