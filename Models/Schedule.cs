using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Models;

[Table("Schedules")]
public class Schedule:BaseModel
{
    public string?  Class{ get; set; }

    public int DayOfWeek{ get; set; }

    public string? Week{ get; set; }

    [ForeignKey(nameof(Lecture))]
    public int LectureId { get; set; }

    [ForeignKey(nameof(LectureRoom))]
    public int LectureRoomId { get; set; }

    public Lecture? Lecture { get; set; }

    public LectureRoom? LectureRoom { get; set; }
}
