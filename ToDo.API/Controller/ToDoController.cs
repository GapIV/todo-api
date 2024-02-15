using Microsoft.AspNetCore.Mvc;

namespace ToDo.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class ToDoController : ControllerBase
{
    private readonly ICommonService<ToDoModel> _service;
    private readonly IMapper _mapper;
    private readonly IValidator<ToDoViewModel> _validator;

    public ToDoController(
        ICommonService<ToDoModel> service, 
        IMapper mapper, 
        IValidator<ToDoViewModel> validator)
    {
        _service = service;
        _mapper = mapper;
        _validator = validator;
    }

    [HttpGet("{id}")]
    public async Task<ToDoViewModel> Get(Guid id)
    {
        return _mapper.Map<ToDoViewModel>(await _service.Get(id));
    }

    [HttpGet]
    public async Task<IEnumerable<ToDoViewModel>> GetAll()
    {
        return _mapper.Map<IEnumerable<ToDoViewModel>>(await _service.GetAll());
    }

    [HttpPost]
    public async Task<ToDoViewModel> Post(ToDoViewModel viewModel)
    {
        await _validator.ValidateAndThrowAsync(viewModel);
        var model = await _service.Create(_mapper.Map<ToDoModel>(viewModel));
        return _mapper.Map<ToDoViewModel>(model);
    }

    [HttpPut]
    public async Task<ToDoViewModel> Put(ToDoViewModel viewModel)
    {
        await _validator.ValidateAndThrowAsync(viewModel);
        var model = await _service.Update(_mapper.Map<ToDoModel>(viewModel));
        return _mapper.Map<ToDoViewModel>(model);
    }

    [HttpDelete]
    public async Task Delete(Guid id)
    {
        await _service.Delete(id);
    }
}
