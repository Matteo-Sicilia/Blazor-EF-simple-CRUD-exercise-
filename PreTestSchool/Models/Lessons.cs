using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreTestSchool.Models;

[Table("lessons", Schema = "schooltest")]
public class Lessons
{
    [Key]
    [Column("lesson_id")]
    public int LessonId { get; set; }
    [ForeignKey("teacher_fk")]
    [Column("teacher_id")]
    public int TeacherId { get; set; }

    [ForeignKey("topic_fk")]
    [Column("topic_id")]
    public int TopicId { get; set; }

    [Column("notes")]
    public string Notes { get; set; }
    [Column("creation_date")]
    public DateTime CreationDate { get; set; }
    [Column("start_date")]
    public DateTime StartDate { get; set; }
    [Column("end_date")]
    public DateTime EndDate { get; set; }
}