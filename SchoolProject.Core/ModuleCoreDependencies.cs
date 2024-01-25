using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Core.Behaviors;
using System.Reflection;

namespace SchoolProject.Core
{
    public static class ModuleCoreDependencies
    {


        public static IServiceCollection AddCoreDependencies(this 
            IServiceCollection services)
        {
            // Configuration of Mediator
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies
            (Assembly.GetExecutingAssembly()));
            //Configuration of AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            ////GET Validators
            //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;    
        }






    }
}
