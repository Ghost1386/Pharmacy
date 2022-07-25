namespace Pharmacy.Models;

public class Receiver
{
    public string Name { get; set; }
    
    public List<Stock> Stock { get; set; } = new();
    
    public List<Supply> Supply { get; set; } = new();
}