using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Commands.Handlers
{
    public class StudentCommandHandler : ResponseHandler,
                                         IRequestHandler<AddStudentCommand, Response<string>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentCommandHandler(IStudentService studentService,IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;   
        }

        public async Task<Response<string>> Handle(AddStudentCommand request, 
            CancellationToken cancellationToken)
        {
            //mapping Between request and student
            var stundentMapper = _mapper.Map<Student>(request);
            //add
            var result = await _studentService.AddAsync(stundentMapper);
            //check Condition
            if (result == "Exist") return UnprocessableEntity<string>("Name is Exist");
            //return response 
            else if (result =="Success") return Success("Added Successfuly");
            else return BadRequest<string>();
        }
    }
}
