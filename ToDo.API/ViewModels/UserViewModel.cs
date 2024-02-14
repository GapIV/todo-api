﻿namespace ToDo.API.ViewModels;

public class UserViewModel
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string? Email { get; set; }

    public List<ToDoViewModel> ToDos { get; set; } = new List<ToDoViewModel>();
}
