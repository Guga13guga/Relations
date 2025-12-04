using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Models;

[Table("Lectures")]
public class Lecture:BaseModel
{
    [ForeignKey(nameof(Subject))]
    public int SubjectId { get; set; }

    [ForeignKey(nameof(Teacher))]
    public int TeacherId { get; set; }

    public Subject? Subject { get; set; }

    public Teacher? Teacher { get; set; }

    public List<Schedule>? Schedules { get; set; }
}
