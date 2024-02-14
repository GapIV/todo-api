namespace ToDo.API.ViewModels;

public class ToDoViewModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string? Body { get; set; }
    public bool Checked { get; set; }

    public Guid UserViewModelId { get; set; }
    public UserViewModel User { get; set; }
}
