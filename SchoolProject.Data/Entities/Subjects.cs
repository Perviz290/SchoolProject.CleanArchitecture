using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Data.Entities;

public class Subjects
{

    public Subjects()
    {
        StudentSubjects = new HashSet<StudentSubject>();
        DepartmetSubjects = new HashSet<DepartmetSubject>();
    }

    [Key]
    public int SubId { get; set; }

    [StringLength(500)]
    public string SubjectName {  get; set; }    
    public DateTime Period { get; set; }    
    public virtual ICollection<StudentSubject>StudentSubjects { get; set; }     
    public virtual ICollection<DepartmetSubject>DepartmetSubjects { get; set; } 






















}
