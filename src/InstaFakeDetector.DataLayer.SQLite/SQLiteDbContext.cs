using InstaFakeDetector.Common.EFCoreToolkit;
using InstaFakeDetector.DataLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace InstaFakeDetector.DataLayer.SQLite;

public class SQLiteDbContext : ApplicationDbContext
{
    public SQLiteDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // NOTE: Add custom SQLite's settings here ...

        builder.AddDateTimeOffsetConverter();
        builder.SetCaseInsensitiveSearchesForSQLite();
    }
}