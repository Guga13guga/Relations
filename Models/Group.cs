

using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Models;

[Table("Groups")]
public class Group : BaseModel
{
    public string? Name { get; set; }

    public int? Year { get; set; }

    public List<GroupCurator>? GroupCurators { get; set; }

    public List<GroupLecture>? GroupLectures { get; set; }
}
