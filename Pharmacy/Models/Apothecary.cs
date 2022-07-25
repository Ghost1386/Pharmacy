using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Models;

public class Apothecary
{
    public int ApothecaryId { get; set; }
    
    public string Name { get; set; }
    
    public string Address { get; set; }
    
    public string Phone { get; set; }
    
    [ForeignKey("DirectorId")]
    public int DirectorId { get; set; }

    public List<Director> Directors { get; set; } = new();
}