using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Data.Entities;

public partial class Department
{

    public Department()
    {
        Students=new HashSet<Student>();
        DepartmetSubjects = new HashSet<DepartmetSubject>();
    }

    [Key]
    public int DID {  get; set; }

    [StringLength(500)]
    public string DName { get; set; }
    public virtual ICollection<Student>Students { get; set; }   
    public virtual ICollection<DepartmetSubject> DepartmetSubjects { get; set; }
   




}
