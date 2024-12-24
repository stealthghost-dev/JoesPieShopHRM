using JoesPieShopHRM.Components;
using JoesPieShopHRM.Contracts.Repositories;
using JoesPieShopHRM.Contracts.Services;
using JoesPieShopHRM.Data;
using JoesPieShopHRM.Repositories;
using JoesPieShopHRM.Services;
using JoesPieShopHRM.State;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(); // for interactive components

//builder.Services.AddDbContext<AppDbContext>(options =>
  //  options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Services section
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IDataService, DataService>();

builder.Services.AddScoped<ApplicationState>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode(); // for interactive components

app.Run();

//Steps to Add EF Core services
//Define model
//Add Required Packages
//Create DBContext
//Configure the application to use EF Core

//Create the database -     
//add-migration initialCreate
//update-database
//add-migration dataAdded
