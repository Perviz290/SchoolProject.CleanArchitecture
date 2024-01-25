﻿using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentQueryHandler : ResponseHandler,
        IRequestHandler<GetStudentListQuery,Response<List<GetStudentListResponse>>>,
        IRequestHandler<GetStudentByIdQuery,Response<GetSingleStudentResponse>>
    {

        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentQueryHandler(IStudentService studentService,IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;   
        }

        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request,
            CancellationToken cancellationToken)
        {
          var studenList =await _studentService.GetStudentsListAsync();
          var studentListMapper = _mapper.Map<List<GetStudentListResponse>>(studenList);
          return Success(studentListMapper);
        }

        public async Task<Response<GetSingleStudentResponse>> Handle(GetStudentByIdQuery request,
            CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentByIdAsync(request.Id);
            if (student == null) return NotFound<GetSingleStudentResponse>("Object not found");
            var result=_mapper.Map<GetSingleStudentResponse>(student);  
            return Success(result); 
        }



    }
}
