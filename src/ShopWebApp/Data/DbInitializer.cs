using ShopWebApp.Models;

namespace ShopWebApp.Data;

public class DbInitializer
{
    public static void Initialize(StoreContext context)
    {
        context.Database.EnsureCreated();
        
        if(context.Categories.Any())
            return;
        var categories = new Category[]
        {
            new Category{CategoryID = 1, CategoryName = "Electronics"},
            new Category{CategoryID = 2, CategoryName = "Books"}
        };
        foreach (var category in categories)
        {
            context.Categories.Add(category);
        }

        context.SaveChanges();
        var products = new Product[]
        {
            new Product { ProductID = "1", ProductName = "Pc", Price = 1000, Category = categories[0]},
            new Product { ProductID = "2", ProductName = "Phone", Price = 500, Category = categories[0]},
            new Product { ProductID = "3", ProductName = "Net for dummies", Price = 200, Category = categories[1]}
        };
        foreach (var product in products)
        {
            context.Products.Add(product);
        }

        context.SaveChanges();
        

    }
}