using Microsoft.EntityFrameworkCore;

namespace ToDo.DAL.Entities;

public class ApplicationContext : DbContext
{
    DbSet<ToDoEntity> ToDos { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {
        Database.EnsureCreated();
    }
}
