using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BLL.Interfaces;

namespace ToDo.BLL.Services;

public class CommonService<T> : ICommonService<T> where T : class
{
    public Task<T> Create(T item)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<T> Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<T> Update(T item)
    {
        throw new NotImplementedException();
    }
}
