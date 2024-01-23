using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;

namespace SchoolProject.Infrustructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
        :base(options){ }

    public DbSet<Department>departments { get; set; }
    public DbSet<Student> students { get; set; }
    public DbSet<DepartmetSubject> departmetSubjects { get; set; }
    public DbSet<Subjects> subjects { get; set; }
    public DbSet<StudentSubject> studentSubjects { get; set; }
   



}
