using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Models;

[Table("Subjects")]
public class Subject:BaseModel
{
    public string? Name { get; set; }

    public List<Lecture>? lectures { get; set; }
}
