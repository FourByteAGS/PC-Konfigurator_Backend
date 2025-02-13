using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class Dimensions
    {
        [Key]
        public Guid id { get; set; }
        public decimal width { get; set; }
        public decimal height { get; set; }
        public decimal depth { get; set; }
    }
}
