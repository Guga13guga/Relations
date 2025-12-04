using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Models;

[Table("LectureRooms")]
public class LectureRoom : BaseModel
{
    public string ? Buillding { get; set; }

    public string ? Name { get; set; }

    public List<Schedule>? Schedules { get; set; }
}
