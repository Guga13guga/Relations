using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Models;
[Table("Deans")]
public class Dean : BaseModel
{
    [ForeignKey(nameof(Teacher))]
    public int TeacherId { get; set; }

    public Teacher? Teacher { get; set; }

    public List<Faculty>? Faculties { get; set; }
}
