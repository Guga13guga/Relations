using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Models;

[Table("Curators")]
public class Curator:BaseModel
{
    [ForeignKey(nameof(Teacher))]
    public int TeacherId { get; set; }

    public Teacher? Teacher { get; set; }

    public List<GroupCurator>? GroupCurators { get; set; }
}
