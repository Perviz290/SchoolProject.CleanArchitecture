using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrustructure.Abstracts;
using SchoolProject.Infrustructure.Data;
using SchoolProject.Infrustructure.InfrustructureBases;

namespace SchoolProject.Infrustructure.Repositories;

public class StudentRepository : GenericRepository<Student>,IStudentRepository
{
    private readonly DbSet<Student> _students;   

    public StudentRepository(ApplicationDbContext dbContext):base(dbContext)
    {
        _students=dbContext.Set<Student>(); 
    }

    public async Task<List<Student>> GetStudentsListAsync()
    {
        return await _students.Include(x=>x.Department).ToListAsync(); 
    }




}
