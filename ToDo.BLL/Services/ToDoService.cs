using AutoMapper;
using ToDo.BLL.Models;
using ToDo.DAL.Entities;
using ToDo.DAL.Interfaces;

namespace ToDo.BLL.Services;

public class ToDoService : CommonService<ToDoEntity, ToDoModel>
{
    public ToDoService(IMapper mapper, IRepository<ToDoEntity> repository) : base(mapper, repository)
    {

    }
}
