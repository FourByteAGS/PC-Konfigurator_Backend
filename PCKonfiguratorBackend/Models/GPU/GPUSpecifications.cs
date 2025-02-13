using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class GPUSpecifications
    {
        [Key]
        public Guid id { get; set; }
        public int memory { get; set; }
        public decimal speed { get; set; }
        public int boostclock { get; set; }
        public int coreclock { get; set; }
        public int power {  get; set; }
    }
}
