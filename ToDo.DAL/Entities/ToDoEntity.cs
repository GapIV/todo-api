namespace ToDo.DAL.Entities;

public class ToDoEntity : CommonEntity 
{
    public string Title { get; set; }
    public string? Body { get; set; }
    public bool Checked { get; set; }

    public Guid UserEntityId { get; set; }
    public UserEntity User { get; set; }
}
