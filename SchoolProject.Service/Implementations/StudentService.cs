using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrustructure.Abstracts;
using SchoolProject.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Implementations
{
    public class StudentService : IStudentService
    {

        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        public async Task<List<Student>> GetStudentsListAsync()
        {
           return await _studentRepository.GetStudentsListAsync();  
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            //var student=await _studentRepository.GetByIdAsync(id); 
            //return student;     
            var student=_studentRepository.GetTableNoTracking()
                .Include(x=>x.Department).Where(x=>x.StudId.Equals(id)).FirstOrDefault();
            return student;
        }

        public async Task<string> AddAsync(Student student)
        {       
           var studentResult=_studentRepository.GetTableNoTracking()
                .Where(x=>x.Name.Equals(student.Name)).FirstOrDefault();

            if (studentResult != null) return "Exist";
            await _studentRepository.AddAsync(student);
            return "Success";
      
        }




    }
}
