using SchoolProject.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Core.Features.Students.Queries.Results
{
    public class GetStudentListResponse
    {

        public int StudId { get; set; }       
        public string? Name { get; set; }
        public string? Address { get; set; }   
        public string? DepartmentName { get; set; }
     

    }
}
