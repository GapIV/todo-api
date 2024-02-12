using ToDo.DAL.Interfaces;

namespace ToDo.DAL.Entities;
public class CommonEntity : IEntity
{
    public Guid Id { get; set; }
}
