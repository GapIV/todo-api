namespace ToDo.BLL.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ToDoEntity, ToDoModel>().ReverseMap();
        CreateMap<UserEntity, UserModel>().ReverseMap();
    }
}
