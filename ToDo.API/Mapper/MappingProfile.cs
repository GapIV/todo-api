namespace ToDo.API.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ToDoModel, ToDoViewModel>().ReverseMap();
        CreateMap<UserModel, UserViewModel>().ReverseMap();
    }
}
