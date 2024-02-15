namespace ToDo.DAL.Repositories;

public class UserRepository : CommonRepository<UserEntity>
{
    public UserRepository(ApplicationContext context) : base(context) 
    {
    }

    public override async Task<UserEntity?> Get(Guid id)
    {
        return await _set.Include(u => u.ToDos).FirstOrDefaultAsync(u => u.Id == id);
    }

    public override async Task<IEnumerable<UserEntity>> GetAll()
    {
        return await _set.Include(u => u.ToDos).ToListAsync();
    }
}
