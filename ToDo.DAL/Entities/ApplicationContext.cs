using Microsoft.EntityFrameworkCore;

namespace ToDo.DAL.Entities;

public class ApplicationContext : DbContext
{
    DbSet<ToDoEntity> ToDos { get; set; }
    DbSet<UserEntity> Users { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>()
            .HasMany(u => u.ToDos)
            .WithOne(td => td.User)
            .HasForeignKey(td => td.UserId);

        base.OnModelCreating(modelBuilder);
    }
}
