using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class CpuFanSpecifications
    {
        [Key]
        public Guid id { get; set; }
        public Socket socket { get; set; }
        public string connector { get; set; }
        public string heatpipes { get; set; }
    }
}
