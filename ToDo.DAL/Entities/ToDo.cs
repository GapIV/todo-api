using ToDo.DAL.Interfaces;

namespace ToDo.DAL.Entities;
public class ToDo : CommonEntity 
{
    public string Title { get; set; }
    public string? Body { get; set; }
    public bool Checked { get; set; }
}
