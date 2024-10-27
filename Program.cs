using DatabaseSync.Data;
using DatabaseSync.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// MSSQL Database
builder.Services.AddDbContext<SourceDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SourceDatabase")));

// SQLite Database
builder.Services.AddDbContext<TargetDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("TargetDatabase")));

builder.Services.AddScoped<DataSyncService>();

builder.Services.AddSingleton<DataSyncBackgroundService>();
builder.Services.AddHostedService(provider => provider.GetService<DataSyncBackgroundService>());


// Serilog configuration
builder.Host.UseSerilog((context, services, configuration) => configuration
    .ReadFrom.Configuration(context.Configuration)
    .ReadFrom.Services(services)
    .Enrich.FromLogContext());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
