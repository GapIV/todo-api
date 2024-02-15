using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToDo.DAL.Entities;
using ToDo.DAL.Interfaces;
using ToDo.DAL.Repositories;

namespace ToDo.DAL.DI;

public static class DataAccessRegister
{
    public static void AddDataAccess(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<IRepository<ToDoEntity>, ToDoRepository>();
        services.AddScoped<IRepository<UserEntity>, UserRepository>();
        services.AddDbContext<ApplicationContext>(options =>
        {
            options.UseNpgsql(config.GetConnectionString("DefaultConnection"));
        });
    }
}
