using InstaFakeDetector.DataLayer.Context;
using InstaFakeDetector.DataLayer.InMemoryDatabase;
using InstaFakeDetector.DataLayer.MSSQL;
using InstaFakeDetector.DataLayer.SQLite;
using InstaFakeDetector.Services.Contracts.Identity;
using InstaFakeDetector.ViewModels.Identity.Settings;
using DNTCommon.Web.Core;
using Microsoft.Extensions.DependencyInjection;

namespace InstaFakeDetector.IocConfig;

public static class DbContextOptionsExtensions
{
    public static IServiceCollection AddConfiguredDbContext(
        this IServiceCollection serviceCollection, SiteSettings siteSettings)
    {
        if (siteSettings == null)
        {
            throw new ArgumentNullException(nameof(siteSettings));
        }

        serviceCollection.AddInterceptors();

        switch (siteSettings.ActiveDatabase)
        {
            case ActiveDatabase.InMemoryDatabase:
                serviceCollection.AddConfiguredInMemoryDbContext(siteSettings);
                break;

            case ActiveDatabase.LocalDb:
            case ActiveDatabase.SqlServer:
                serviceCollection.AddConfiguredMsSqlDbContext(siteSettings);
                break;

            case ActiveDatabase.SQLite:
                serviceCollection.AddConfiguredSQLiteDbContext(siteSettings);
                break;

            default:
                throw new NotSupportedException("Please set the ActiveDatabase in appsettings.json file.");
        }

        return serviceCollection;
    }

    /// <summary>
    ///     Creates and seeds the database.
    /// </summary>
    public static void InitializeDb(this IServiceProvider serviceProvider)
    {
        serviceProvider.RunScopedService<IIdentityDbInitializer>(identityDbInitialize =>
        {
            identityDbInitialize.Initialize();
            identityDbInitialize.SeedData();
        });
    }

    private static void AddInterceptors(this IServiceCollection services)
    {
        services.AddSingleton<AuditableEntitiesInterceptor>();
    }
}