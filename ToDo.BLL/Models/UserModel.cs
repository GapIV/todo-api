﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.BLL.Models;
public class UserModel
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string? Email { get; set; }

    public List<ToDoModel> ToDos { get; set; } = new List<ToDoModel>();
}
