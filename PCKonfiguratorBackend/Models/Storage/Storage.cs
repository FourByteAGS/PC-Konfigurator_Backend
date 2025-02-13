using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class Storage
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
        public string manufacturer { get; set; }
        public decimal price { get; set; }
        public string image { get; set; }
        public StorageSpecifications storageSpecifications { get; set; }
    }
}
