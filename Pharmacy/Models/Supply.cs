namespace Pharmacy.Models;

public class Supply
{
    public int SupplyId { get; set; }
    
    public DateTime DateSupply { get; set; }
    
    public int Amount { get; set; }
    
    public decimal Price { get; set; }
    
    public List<Manufacturer> Manufacturer { get; set; } = new();
    
    public List<Stock> Stock { get; set; } = new();
}