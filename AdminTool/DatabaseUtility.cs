using AdminTool.Data;
using Microsoft.EntityFrameworkCore;

namespace AdminTool;

public static class DatabaseUtility
{
    public static async Task EnsureDbCreatedAndSeedAsync(DbContextOptions<UserContext> options)
    {
        var factory = new LoggerFactory();
        var builder = new DbContextOptionsBuilder<UserContext>(options)
            .UseLoggerFactory(factory);

        using var context = new UserContext(builder.Options);

        if (await context.Database.EnsureCreatedAsync())
        {
            var seed = new SeedUsers();
            await seed.SeedDatabaseAsync(context);
        }
    }
}
