namespace ToDo.BLL.Interfaces;

public interface ICommonService<T> where T : class
{
    Task<T> Get(Guid id);
    Task<T> GetAll();
    Task<T> Create(T item);
    Task<T> Update(T item);
    Task Delete(Guid id);
}
