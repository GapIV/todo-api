using AutoMapper;
using ToDo.BLL.Interfaces;
using ToDo.DAL.Interfaces;

namespace ToDo.BLL.Services;

public class CommonService<TEntity, TModel> : ICommonService<TModel> 
    where TEntity : class 
    where TModel : class
{
    protected readonly IMapper _mapper;
    protected readonly IRepository<TEntity> _repository;

    public CommonService(IMapper mapper, IRepository<TEntity> repository) 
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<TModel> Create(TModel model)
    {
        var entity = await _repository.Create(_mapper.Map<TEntity>(model));
        return _mapper.Map<TModel>(entity);
    }

    public async Task Delete(Guid id)
    {
        await _repository.Delete(id);
    }

    public async Task<TModel> Get(Guid id)
    {
        var entity = await _repository.Get(id);
        return _mapper.Map<TModel>(entity);
    }

    public async Task<IEnumerable<TModel>> GetAll()
    {
        return _mapper.Map<IEnumerable<TModel>>(await _repository.GetAll());
    }

    public async Task<TModel> Update(TModel model)
    {
        var entity = await _repository.Update(_mapper.Map<TEntity>(model));
        return _mapper.Map<TModel>(entity);
    }
}
