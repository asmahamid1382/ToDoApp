using Microsoft.EntityFrameworkCore;
public class MYDayContext:DbContext
{
    public MYDayContext(DbContextOptions<MYDayContext> options)
        : base(options)
    {
    }

    public MYDayContext()
    {
    }

    public DbSet<MyTask> Tasks { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=MYDay.db");
    }
}