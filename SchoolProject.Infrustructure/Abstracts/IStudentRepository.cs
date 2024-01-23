using SchoolProject.Data.Entities;

namespace SchoolProject.Infrustructure.Abstracts;

public interface IStudentRepository
{
    
    Task<List<Student>>GetStudentsListAsync();







}
