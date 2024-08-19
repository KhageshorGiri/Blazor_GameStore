using System.ComponentModel.DataAnnotations;

namespace GameStore.Models.Base;

public class BaseModel
{
    [Key]
    public int Id { get; set; }
}
