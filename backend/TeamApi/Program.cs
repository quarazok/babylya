var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();
app.UseCors();

var team = new[]
{
    new { name = "леший", role = "Tech Lead", fact = "Люблю C#" },
    new { name = "сашуля", role = "Developer", fact = "Пишу на C# с 1 курса" },
    new { name = "тоже сашуля", role = "QA", fact = "Нахожу баги быстрее всех" }
};

app.MapGet("/api/team", () => Results.Ok(team));

app.MapGet("/api/team/{name}", (string name) =>
{
    var member = team.FirstOrDefault(m =>
        m.name.Contains(name, StringComparison.OrdinalIgnoreCase));
    return member is not null ? Results.Ok(member) : Results.NotFound();
});

app.Run();