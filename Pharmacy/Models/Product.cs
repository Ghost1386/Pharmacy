using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Models;

public class Product
{
    public int ProductId { get; set; }
    
    public string Title { get; set; }
    
    public int Amount { get; set; }
    
    public decimal Price { get; set; }

    public List<Manufacturer> Manufacturer { get; set; } = new();

    public List<Stock> Stock { get; set; } = new();
}