using DependencyInjection.Interfaces;
using DependencyInjection.Models;

var builder = WebApplication.CreateBuilder(args);

// Dependency Injection burada tanımlanıyor
builder.Services.AddScoped<IOgretmen>(provider =>
{
    return new Teacher("Halenur", "İncedere");
});
builder.Services.AddScoped<ClassRoom>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", (ClassRoom classRoom) =>
{
    return Results.Ok(classRoom.GetTeacherInfo());
});

app.Run();