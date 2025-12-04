
using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Models;
[ Table("GropLectures")]
public class GroupLecture : BaseModel
{
    [ForeignKey(nameof(Group))]
    public int GroupId { get; set; }
    public Group? Group { get; set; }

    [ForeignKey(nameof(Lecture))]
    public int LectureId { get; set; }
    public Lecture? Lecture { get; set; }
}

