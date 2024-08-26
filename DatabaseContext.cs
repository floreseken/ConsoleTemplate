using ConsoleTemplate.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ConsoleTemplate;

public class DatabaseContext(IConfiguration config) : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connStr = config.GetConnectionString("Database");
        optionsBuilder.UseSqlServer(connStr);
    }

    public DbSet<BlogPost> BlogPosts { get; set; } = null!;

    public DbSet<Comment> Comments { get; set; } = null!;

}
