using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Models;

public class Order
{
    public int OrderId { get; set; }
    
    public int AmountOrder { get; set; }
    
    public DateTime DateOrder { get; set; }
    
    public decimal PriceOrder { get; set; }
    
    public List<Apothecary> Apothecary { get; set; } = new();
    
    public List<Stock> Stock { get; set; } = new();
}