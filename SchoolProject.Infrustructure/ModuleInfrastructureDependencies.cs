using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrustructure.Abstracts;
using SchoolProject.Infrustructure.InfrustructureBases;
using SchoolProject.Infrustructure.Repositories;

namespace SchoolProject.Infrustructure;

public static class ModuleInfrastructureDependencies
{
    public static IServiceCollection AddInfrastructureDependencies(
        this IServiceCollection services)
    {
        services.AddTransient<IStudentRepository, StudentRepository>();
        services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        return services;
    }



}
