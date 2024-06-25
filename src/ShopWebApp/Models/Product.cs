using System.ComponentModel.DataAnnotations.Schema;

namespace ShopWebApp.Models;

public class Product
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string ProductID { get; set; }
    public string ProductName { get; set; }
    public int Price { get; set; }
    public DateTime Created => DateTime.Now;
    public Category Category{ get; set; }
}