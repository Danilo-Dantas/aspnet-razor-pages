using Microsoft.EntityFrameworkCore;
using RazorPages.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddDbContext<MoviesContext>(option => 
    option.UseInMemoryDatabase("MyFirstAppDB"));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages(); 

app.Run();
