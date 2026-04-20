using Microsoft.EntityFrameworkCore;
using DotnetApi.Data;
using DotnetApi.Features.Jobs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=app.db"));

builder.Services.AddScoped<JobService>();

var app = builder.Build();

app.MapGet("/", () => "Running");

app.MapGet("/health", () => Results.Ok(new
{
    status = "ok",
    time = DateTime.UtcNow
}));

app.Run();
