using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adds controller and view services.
builder.Services.AddControllersWithViews();

// Adds DbContext service
builder.Services.AddDbContext<_6_1_FAQs.Data.FaqContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FaqContext")));

var app = builder.Build();

// Error handle and HTTP settings.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Middleware for redirection, files, and routing.
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Map routing for navigation.
app.MapControllerRoute(
    name: "filter",
    pattern: "{controller=Home}/{action=Index}/topic/{topic?}/category/{category?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();