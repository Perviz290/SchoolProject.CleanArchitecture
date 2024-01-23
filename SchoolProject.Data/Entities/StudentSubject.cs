using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Data.Entities;

public class StudentSubject
{
    [Key]
    public int StudSubId { get; set; }
    public int StudId {  get; set; }    
    public int SubId {  get; set; }

    [ForeignKey("StudId")]
    public virtual Student Student { get; set; }

    [ForeignKey("SubId")]
    public virtual Subjects Subject { get; set; }


}
