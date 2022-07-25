using Microsoft.EntityFrameworkCore;
using Pharmacy.Models;

namespace Pharmacy
{
    class Program
    {
        public static void Main(string[] args)
        {
            
        }
        
        public void CascadeDelete()
        {
            ApplicationContext applicationContext = new ApplicationContext();
            if (applicationContext.Directors != null)
            {
                Director director = applicationContext.Directors.OrderBy(e => e.Name).
                    Include(e => e.DirectorId).First();

                applicationContext.Remove(director);
            }

            applicationContext.SaveChanges();
        }
        
        public List<Apothecary> GetApothecaryWithView()
        {
            ApplicationContext applicationContext = new ApplicationContext();
            List<Apothecary> apothecaries = applicationContext.ApothecariesView.ToList();
            return apothecaries;
        }
    }
}
