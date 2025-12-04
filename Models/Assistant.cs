using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Models;

[Table("Assistants")]
public class Assistant : BaseModel
{
    public string? Name { get; set; }

    [ForeignKey(nameof(Teacher))]
    public int TeacherId { get; set; }

    public Teacher? Teacher { get; set; }
}
