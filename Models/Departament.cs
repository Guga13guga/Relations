using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Models;
[Table("Departaments")]

public class Departament : BaseModel
{
    public string? Building {  get; set; }

    public string? Name { get; set; }

    [ForeignKey("Faculty")]
    public int FacultyId { get; set; }

    public int HeadId { get; set; }

    public Faculty? Faculty { get; set; }
    
}
