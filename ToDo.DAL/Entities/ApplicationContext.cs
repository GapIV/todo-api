using Microsoft.EntityFrameworkCore;

namespace ToDo.DAL.Entities;

public class ApplicationContext : DbContext
{
    DbSet<ToDoEntity> ToDos { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("host=localhost; port=5432; database=ToDo; username=postgres; password=postgres");
    }
}
