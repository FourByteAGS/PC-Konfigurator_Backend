using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class Dimensions
    {
        [Key]
        public Guid id { get; set; }
        public float? width { get; set; }
        public float? height { get; set; }
        public float? depth { get; set; }
    }
}
