using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Models;

[Table("Curators")]
public class Curator
{
    [ForeignKey(nameof(Teacher))]
    public int TeacherId { get; set; }

    public Teacher? Teacher { get; set; }
}
