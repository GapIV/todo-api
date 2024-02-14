using AutoMapper;
using ToDo.BLL.Models;
using ToDo.DAL.Entities;
using ToDo.DAL.Interfaces;

namespace ToDo.BLL.Services;

public class UserService : CommonService<UserEntity, UserModel>
{
    public UserService(IMapper mapper, IRepository<UserEntity> repository) : base(mapper, repository) 
    {
    }
}
