using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EFTest.Models;
using EFTest.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataBaseContext>(
    op => op.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StudentGrade;Trusted_Connection=True;"));
builder.Services.AddMvc(option => option.EnableEndpointRouting = false);
builder.Services.AddScoped<IRepository, SqlServerRepository>();

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

app.UseMvc();

app.Run();
