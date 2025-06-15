using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data;

public class MyAppDbContext : DbContext
{
    public MyAppDbContext(DbContextOptions<MyAppDbContext> options): base(options) 
    { 
        //  Database.EnsureCreated();
        //  Database.Migrate();
    }

    public DbSet<Item> Items {get; set;}
}