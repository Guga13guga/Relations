

using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Models;

[Table("Heads")]
public class Head : BaseModel
{
    [ForeignKey(nameof(Teacher))]
    public int TeacherId { get; set; }

    public Teacher? Teacher { get; set; }

    //public List<Departament>? Departaments { get; set; }
}
