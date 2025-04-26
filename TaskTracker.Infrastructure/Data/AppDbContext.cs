using Microsoft.EntityFrameworkCore;
using TaskTracker.Core.Entities;

namespace TaskTracker.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<TaskItem> TaskItems { get; set; }
}