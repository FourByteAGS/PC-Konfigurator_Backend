using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class CPU
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int CoreCount { get; set; }
        public double BaseClock { get; set; }
        public double BoostClock { get; set; }
        public string Socket { get; set; }
    }
}
