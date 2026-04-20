using Microsoft.EntityFrameworkCore;
using DotnetApi.Features.Jobs;

namespace DotnetApi.Data;

public class AppDbContext : DbContext
{
    public DbSet<JobRecord> Jobs => Set<JobRecord>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}
