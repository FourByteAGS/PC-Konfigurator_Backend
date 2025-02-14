using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class RAM
    {
        [Key]
        public Guid id { get; set; }
        public string? name { get; set; }
        public string? manufacturer { get; set; }
        public float? price { get; set; }
        public string? image { get; set; }
        public RAMSpecifications ramSpecifications { get; set; } = new RAMSpecifications();
    }
}
