namespace DotnetApi.Features.Jobs;

public static class JobsEndpoint
{
    public static void MapJobs(this WebApplication app)
    {
        app.MapPost("/jobs/run", async (
            JobRequest request,
            JobService service) =>
        {
            var result = await service.Create(request);
            return Results.Ok(result);
        });
    }
}
