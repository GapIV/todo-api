namespace ToDo.BLL.Services;

public class UserService : CommonService<UserEntity, UserModel>
{
    public UserService(IMapper mapper, IRepository<UserEntity> repository) : base(mapper, repository) 
    {
    }
}
