using AutoMapper;
using ToDo.BLL.Models;
using ToDo.DAL.Entities;


namespace ToDo.BLL.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ToDoEntity, ToDoModel>().ReverseMap();
        CreateMap<UserEntity, UserModel>().ReverseMap();
    }
}
