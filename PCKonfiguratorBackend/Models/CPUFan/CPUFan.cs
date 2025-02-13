using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class CPUFan
    {
        [Key]
        public Guid id { get; set; }
        public string? name { get; set; }
        public string? manufacturer { get; set; }
        public float? price { get; set; }
        public string? image { get; set; }
        public CpuFanSpecifications cpufanSpecifications { get; set; } = new CpuFanSpecifications();
        public Dimensions dimensions { get; set; } = new Dimensions();
    }
}
