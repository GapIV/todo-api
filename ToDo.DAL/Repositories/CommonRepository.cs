namespace ToDo.DAL.Repositories;

public class CommonRepository<T> : IRepository<T> where T : CommonEntity
{
    protected readonly DbSet<T> _set;
    protected readonly ApplicationContext _context;

    public CommonRepository(ApplicationContext context)
    {
        _context = context;
        _set = _context.Set<T>();
    }

    public async Task<T> Create(T entity)
    {
        entity.Id = Guid.NewGuid();
        _set.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task Delete(Guid id)
    {
        var entity = _set.FirstOrDefault(
            entity => entity.Id == id);
        
        if (entity == null)
            throw new InvalidOperationException();

        _set.Remove(entity);

        await _context.SaveChangesAsync();
    }

    public virtual async Task<T> Get(Guid id)
    {
        return await _set.FirstAsync(entity => entity.Id == id);
    }

    public virtual async Task<IEnumerable<T>> GetAll()
    {
        return await _set.ToListAsync();
    }

    public async Task<T> Update(T entity)
    {
        _set.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return entity;
    }
}
