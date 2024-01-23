using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrustructure.Abstracts;
using SchoolProject.Infrustructure.Repositories;

namespace SchoolProject.Infrustructure;

public static class ModuleInfrastructureDependencies
{
    public static IServiceCollection AddInfrastructureDependencies(
        this IServiceCollection services)
    {
        services.AddTransient<IStudentRepository, StudentRepository>();
        return services;
    }



}
