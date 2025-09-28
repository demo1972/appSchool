using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace App.School.v3.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class v3DbContextFactory : IDesignTimeDbContextFactory<v3DbContext>
{
    public v3DbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        v3EfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<v3DbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new v3DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../App.School.v3.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
