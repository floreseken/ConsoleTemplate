using ConsoleTemplate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var host = Host.CreateDefaultBuilder(args)
     .ConfigureServices((context, services) => 
            { 
                services.AddDbContext<DatabaseContext>(opt => opt.UseSqlServer());
                services.AddTransient<EntryPoint>(); 
            })
    .Build();

var my = host.Services.GetRequiredService<EntryPoint>();
await my.ExecuteAsync();
