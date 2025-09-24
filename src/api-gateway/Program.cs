var builder = WebApplication.CreateBuilder(args);

// Swagger/OpenAPI for easy testing
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Health probe for readiness checks
app.MapGet("/api/health", () => Results.Ok(new { status = "ok" }));

// Temporary sample endpoint so UI/tests have something to call
var sample = new[] {
    new { id = 1, severity = "low", message = "Service A ping ok" },
    new { id = 2, severity = "medium", message = "CPU spike detected" }
};
app.MapGet("/api/incidents", () => Results.Ok(sample));

app.Run();
