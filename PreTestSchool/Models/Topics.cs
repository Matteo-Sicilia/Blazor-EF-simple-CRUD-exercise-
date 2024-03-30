using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreTestSchool.Models;

[Table("topics", Schema = "schooltest")]
public class Topics
{
    [Key]
    [Column("topics_id")]
    public int TopicId { get; set; }
    [Column("name")]
    public string TopicName { get; set; }
}