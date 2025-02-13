using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class RAMSpecifications
    {
        [Key]
        public Guid id { get; set; }
        public MemoryType MemoryType { get; set; }
        public int speed { get; set; }
        public int capacity { get; set; }
        public decimal voltage { get; set; }
    }
}
