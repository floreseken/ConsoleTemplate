using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ConsoleTemplate;

public class EntryPoint(ILogger<EntryPoint> logger, DatabaseContext context)
{

    public async Task ExecuteAsync(CancellationToken cancellationToken = default)
    {
        logger.LogInformation("Doing something");

        await context.Database.EnsureCreatedAsync(cancellationToken);

        await context.BlogPosts.ToListAsync(cancellationToken);
    }
}