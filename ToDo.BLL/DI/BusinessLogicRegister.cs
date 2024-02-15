using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToDo.BLL.Mapper;
using ToDo.BLL.Services;
using ToDo.DAL.DI;

namespace ToDo.BLL.DI;

public static class BusinessLogicRegister
{
    public static void AddBusinessLogic(this IServiceCollection services, IConfiguration config)
    {
        services.AddAutoMapper(typeof(MappingProfile));
        services.AddScoped<ICommonService<ToDoModel>, ToDoService>();
        services.AddScoped<ICommonService<UserModel>, UserService>();
        DataAccessRegister.AddDataAccess(services, config);
    }
}
