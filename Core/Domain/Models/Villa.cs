using System.ComponentModel.DataAnnotations;

namespace EFCoreTask.Core.Domain.Models
{
    public class Villa
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        
        public ICollection<VillaAmanity> villaAmanities { get; set; }
    }
}
