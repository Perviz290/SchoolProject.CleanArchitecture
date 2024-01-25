using SchoolProject.Core.Features.Students.Queries.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.Student
{
    public partial class StudentProfile
    {

        public void GetStudentByIdMapping()
        {
            CreateMap<Data.Entities.Student, GetSingleStudentResponse>()
                   .ForMember(dest => dest.DepartmentName,
                   opt => opt.MapFrom(src => src.Department.DName));
        }


    }
}
