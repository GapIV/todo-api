namespace ToDo.DAL.Entities;

public class UserEntity : CommonEntity
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string? Email { get; set; }

    public List<ToDoEntity> ToDos { get; set; } = new List<ToDoEntity>();
}
