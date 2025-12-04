using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Models;

[Table("Teachers")]
public class Teacher : BaseModel
{
    public string? Name { get; set; }

    public string? Surname { get; set; }

    public List<Assistant>? Assistants { get; set; }

    public List<Lecture>? Lectures { get; set; }

    public List<Dean>? Deans { get; set; }

    public List<Curator>? Curators { get; set; }
}
