using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Models;

public class Manufacturer
{
    public int ManufacturerId { get; set; }
    
    public string Name { get; set; }
    
    public string Address { get; set; }
    
    public string Phone { get; set; }
    
    [ForeignKey("CountryId")]
    public int CountryId { get; set; }
}