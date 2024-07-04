using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTask.Core.Domain.Models
{
    public class VillaAmanity
    {
        public int Id { get; set; }

        public int VillaId { get; set; }
        public Villa Villa { get; set; }

        public required string Name { get; set; }
    }
}
