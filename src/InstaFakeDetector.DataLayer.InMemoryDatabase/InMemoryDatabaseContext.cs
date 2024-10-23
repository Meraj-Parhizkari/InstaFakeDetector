using InstaFakeDetector.DataLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace InstaFakeDetector.DataLayer.InMemoryDatabase;

public class InMemoryDatabaseContext : ApplicationDbContext
{
    public InMemoryDatabaseContext(DbContextOptions options) : base(options)
    {
    }
}