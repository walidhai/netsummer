using Microsoft.EntityFrameworkCore;

using ShopWebApp.Models;

namespace ShopWebApp.Data;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {
    }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().ToTable("Category");
        modelBuilder.Entity<Product>().ToTable("Product");
    }
}