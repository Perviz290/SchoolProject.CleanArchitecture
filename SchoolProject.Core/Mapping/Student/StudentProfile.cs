using AutoMapper;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;

namespace SchoolProject.Core.Mapping.Student
{
    public partial class StudentProfile : Profile
    {

        public StudentProfile()
        {
            GetStudentListMapping();   
        }


    }
}
