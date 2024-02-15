namespace ToDo.BLL.Services;

public class ToDoService : CommonService<ToDoEntity, ToDoModel>
{
    public ToDoService(IMapper mapper, IRepository<ToDoEntity> repository) : base(mapper, repository)
    {

    }
}
