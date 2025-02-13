using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class CPUMemory
    {
        [Key]
        public Guid id { get; set; }
        public MemoryType memoryType { get; set; }
        public int maxCapacity { get; set; }
        public decimal maxSpeed { get; set; }
    }
}
