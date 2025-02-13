using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class MainboardSpecifications
    {
        [Key]
        public Guid id { get; set; }
        public Socket socket { get; set; }
        public string chipset { get; set; }
        public int m2Slot { get; set; }
        public int sataPorts { get; set; }
        public FormFactor formFactor { get; set; }
        public MemoryType memoryType { get; set; }
    }
}
