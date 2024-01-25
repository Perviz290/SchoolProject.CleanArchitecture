using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;

namespace SchoolProject.Core.Mapping.Student
{
    public partial class StudentProfile
    {

        public void AddStudentCommandMapper()
        {
            CreateMap<AddStudentCommand, Data.Entities.Student>()
                   .ForMember(dest => dest.DID,
                   opt => opt.MapFrom(src => src.DepartmementId));
        }


    }
}
