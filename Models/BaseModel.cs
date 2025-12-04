using System.ComponentModel.DataAnnotations;

namespace Relations.Models;

public abstract class BaseModel
{
    [Key]
    public  int Id { get; set; }
}
