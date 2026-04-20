using DotnetApi.Data;

namespace DotnetApi.Features.Jobs;

public class JobService
{
    private readonly AppDbContext db;

    public JobService(AppDbContext db)
    {
        this.db = db;
    }

    public async Task<JobRecord> Create(JobRequest request)
    {
        var job = new JobRecord
        {
            Command = request.Command
        };

        db.Jobs.Add(job);
        await db.SaveChangesAsync();

        return job;
    }
}
