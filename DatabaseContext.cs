using ConsoleTemplate.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ConsoleTemplate;

public class DatabaseContext : DbContext
{
    private readonly IConfiguration config;

    public DatabaseContext(IConfiguration config)
    {
        this.config = config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connStr = this.config.GetConnectionString("Database");
        optionsBuilder.UseSqlServer(connStr);
    }

    public DbSet<BlogPost> BlogPosts { get; set; } = null!;

    public DbSet<Comment> Comments { get; set; } = null!;

}
