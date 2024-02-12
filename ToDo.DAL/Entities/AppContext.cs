using Microsoft.EntityFrameworkCore;

namespace ToDo.DAL.Entities;

public class AppContext : DbContext
{
    DbSet<ToDo> ToDos { get; set; }

    public AppContext() {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("host=localhost; port=5432; database=ToDo; username=postgres; password=postgres");
    }
}
