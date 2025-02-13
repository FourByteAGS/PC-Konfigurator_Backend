using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class Mainboard
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
        public string manufacturer { get; set; }
        public decimal price { get; set; }
        public string image { get; set; }
        public MainboardSpecifications mainboardSpecifications { get; set; }
        public Dimensions dimensions { get; set; }
    }
}
