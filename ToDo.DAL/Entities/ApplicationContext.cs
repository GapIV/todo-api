using Microsoft.EntityFrameworkCore;

namespace ToDo.DAL.Entities;

public class ApplicationContext : DbContext
{
    DbSet<ToDo> ToDos { get; set; }

    public ApplicationContext() {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("host=localhost; port=5432; database=ToDo; username=postgres; password=postgres");
    }
}
