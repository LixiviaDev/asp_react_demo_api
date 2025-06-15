using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data;

public class MyAppDbContext : DbContext
{
    public MyAppDbContext(DbContextOptions<MyAppDbContext> options): base(options) { }

    public DbSet<Item> Items {get; set;}
}