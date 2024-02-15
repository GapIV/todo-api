namespace ToDo.BLL.Models;

public class ToDoModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string? Body { get; set; }
    public bool Checked { get; set; }

    public Guid UserId { get; set; }
    public UserModel? User { get; set; }
}
