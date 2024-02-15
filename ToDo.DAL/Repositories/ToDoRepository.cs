namespace ToDo.DAL.Repositories;

public class ToDoRepository : CommonRepository<ToDoEntity>
{
    public ToDoRepository(ApplicationContext context) : base(context) 
    {
    }

    public override async Task<ToDoEntity?> Get(Guid id)
    {
        return await _set.Include(e => e.User).FirstOrDefaultAsync(e => e.Id == id);
    }

    public override async Task<IEnumerable<ToDoEntity>> GetAll()
    {
        return await _set.Include(e => e.User).ToListAsync();
    }
}
