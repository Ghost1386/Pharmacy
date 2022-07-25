namespace Pharmacy.Models;

public class Stock
{
    public int StockId { get; set; }
    
    public string Address { get; set; }
    
    public string Phone { get; set; }
    
    public List<Manager> Manager { get; set; } = new();
    
    public double Square { get; set; }
}