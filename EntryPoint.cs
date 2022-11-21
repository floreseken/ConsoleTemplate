using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Serilog;
using System;
using System.Threading.Tasks;

namespace ConsoleTemplate;

public class EntryPoint
{
    private readonly ILogger<EntryPoint> _logger;
    private readonly DatabaseContext context;

    public EntryPoint(ILogger<EntryPoint> logger, DatabaseContext context)
    {
        _logger = logger;
        this.context = context;
    }

    public async Task ExecuteAsync(CancellationToken stoppingToken = default)
    {
        _logger.LogInformation("Doing something");

        await context.Database.EnsureCreatedAsync();

        context.BlogPosts.ToList();
    }
}