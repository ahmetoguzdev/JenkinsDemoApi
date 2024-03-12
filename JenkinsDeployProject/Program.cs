var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

builder.Services.AddControllers();

app.Run();

