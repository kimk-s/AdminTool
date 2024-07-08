using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AdminTool.Data;

public class UserContext : DbContext
{
    public static readonly string UserDb = nameof(UserDb).ToLower();

    public DbSet<User> Users { get; set; }

    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
        Debug.WriteLine($"{ContextId} context created.");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseInMemoryDatabase(nameof(UserDb));
}
