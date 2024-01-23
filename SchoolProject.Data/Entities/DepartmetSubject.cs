using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Data.Entities;

public class DepartmetSubject
{

    [Key]
    public int DeptSubId {  get; set; } 


    public int DID {  get; set; }   
    public int SubId {  get; set; }

    [ForeignKey("DID")]
    public virtual Department Department {  get; set; }

    [ForeignKey("SubId")]
    public virtual Subjects Subjects { get; set; }










}
