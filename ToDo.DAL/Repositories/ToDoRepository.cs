using ToDo.DAL.Entities;

namespace ToDo.DAL.Repositories;

public class ToDoRepository : CommonRepository<ToDoEntity>
{
    public ToDoRepository(ApplicationContext context) : base(context) { }
}
