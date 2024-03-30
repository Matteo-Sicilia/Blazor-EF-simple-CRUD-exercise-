using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreTestSchool.Models;

[Table("teachers", Schema = "schooltest")]
public class Teachers
{
    [Key]
    [Column("teacher_id")]
    public int TeacherId { get; set; }

    [Column("name")]
    public string TeacherName { get; set; } = default!;
}