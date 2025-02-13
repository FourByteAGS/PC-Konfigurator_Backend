using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class GPU
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
        public string manufacturer { get; set; }
        public float price { get; set; }
        public string image { get; set; }
        public GPUSpecifications gpuSpecifications { get; set; }
        public Dimensions dimensions { get; set; }
    }
}
