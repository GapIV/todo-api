using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using ToDo.API.ViewModels;
using ToDo.BLL.Interfaces;
using ToDo.BLL.Models;

namespace ToDo.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly ICommonService<UserModel> _service;
    private readonly IMapper _mapper;
    private readonly IValidator<UserViewModel> _validator;

    public UserController(
        ICommonService<UserModel> service,
        IMapper mapper,
        IValidator<UserViewModel> validator)
    {
        _service = service;
        _mapper = mapper;
        _validator = validator;
    }

    [HttpGet("{id}")]
    public async Task<UserViewModel> Get(Guid id)
    {
        return _mapper.Map<UserViewModel>(await _service.Get(id));
    }

    [HttpGet]
    public async Task<IEnumerable<UserViewModel>> GetAll()
    {
        return _mapper.Map<IEnumerable<UserViewModel>>(await _service.GetAll());
    }

    [HttpPost]
    public async Task<UserViewModel> Post(UserViewModel viewModel)
    {
        await _validator.ValidateAndThrowAsync(viewModel);
        var model = await _service.Create(_mapper.Map<UserModel>(viewModel));
        return _mapper.Map<UserViewModel>(model);
    }

    [HttpPut]
    public async Task<UserViewModel> Put(UserViewModel viewModel)
    {
        await _validator.ValidateAndThrowAsync(viewModel);
        var model = await _service.Update(_mapper.Map<UserModel>(viewModel));
        return _mapper.Map<UserViewModel>(model);
    }

    [HttpDelete]
    public async Task Delete(Guid id)
    {
        await _service.Delete(id);
    }
}
