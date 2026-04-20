namespace DotnetApi.Features.Jobs;

public record JobRequest(string Command);

public class JobRecord
{
    public int Id { get; set; }
    public string Command { get; set; } = "";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
