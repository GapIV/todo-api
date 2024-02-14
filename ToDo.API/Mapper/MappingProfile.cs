using AutoMapper;
using ToDo.API.ViewModels;
using ToDo.BLL.Models;

namespace ToDo.API.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ToDoModel, ToDoViewModel>().ReverseMap();
        CreateMap<UserModel, UserViewModel>().ReverseMap();
    }
}
