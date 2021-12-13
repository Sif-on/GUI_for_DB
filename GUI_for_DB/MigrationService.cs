using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

public static IWebHost MigrateDatabase<T>(this IWebHost webHost) where T : DbContext
{
    using(var scope = webHost.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        try
        {
            var db = services.GetRequiredService<T>();
            db.Database.Migrate();
        }
        catch (Exception ex)
        {
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, "An error occurred while migrating the database.");
        }
    }
    return webHost;
}

public static void Main(string[] args)
{
    CreateWebHostBuilder(args)
        .Build()
        //placeholder database context
        .MigrateDatabase<PHDatabaseContext>()
        .Run();
}