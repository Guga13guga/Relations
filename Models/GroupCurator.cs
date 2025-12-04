

using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Models;

[Table("GroupCurators")]
public class GroupCurator : BaseModel
{
    [ForeignKey(nameof(Curator))]
    public int CuratorId { get; set; }

    [ForeignKey(nameof(Group))]
    public int GroupId { get; set; }
    public Curator? Curator { get; set; }
    public Group? Group { get; set; }
}
