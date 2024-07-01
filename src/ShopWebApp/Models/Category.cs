using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopWebApp.Models;

public class Category
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Key]
    public int CategoryID { get; set; }
    
    public string CategoryName { get; set; }
    
}