using FluentValidation;
using SchoolProject.Core.Features.Students.Commands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Commands.Validations
{
    public class AddStudentValidator  : AbstractValidator<AddStudentCommand>
    {

        public AddStudentValidator()
        {
            RuleFor(x => x.Name)
                  .NotEmpty().WithMessage("Name must not be Empty")
                  .NotNull().WithMessage("Name must not be null")
                  .MaximumLength(10).WithMessage("Max Lenght is 10");

            RuleFor(x => x.Address)
                 .NotEmpty().WithMessage("{PropertyName} must not be Empty")
                 .NotNull().WithMessage("{PropertyName} must not be null")
                 .MaximumLength(10).WithMessage("{PropertyName} Lenght is 10");
        }

   




    }
}
