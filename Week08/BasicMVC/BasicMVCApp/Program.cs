var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // MVC Services

var app = builder.Build();

app.UseStaticFiles(); // Using static files

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Routing Configuration

app.Run();