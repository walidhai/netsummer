using Microsoft.EntityFrameworkCore;

using ShopWebApp.Models;

namespace ShopWebApp.Data;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {
    }
    
    public DbSet<Category> Courses { get; set; }
    public DbSet<Product> Enrollments { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().ToTable("Category");
        modelBuilder.Entity<Product>().ToTable("Product");
    }
}