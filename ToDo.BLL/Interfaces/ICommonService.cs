namespace ToDo.BLL.Interfaces;

public interface ICommonService<T> where T : class
{
    Task<T> Get(Guid id);
    Task<IEnumerable<T>> GetAll();
    Task<T> Create(T model);
    Task<T> Update(T model);
    Task Delete(Guid id);
}
